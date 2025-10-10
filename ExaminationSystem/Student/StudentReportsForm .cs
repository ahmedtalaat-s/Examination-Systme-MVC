using BL.Contracts;
using BL.Services;
using Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;


namespace ExaminationSystem.Student
{
    public partial class StudentReport : Form
    {

        private readonly IStudent _studentService;
        private readonly User _user;
        private List<Report> _reports;

        public bool backPressed = false;

        public StudentReport(IStudent studentService, User user)
        {
            InitializeComponent();
            _studentService = studentService;
            _user = user;
        }

        private void StudentReportsForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            _reports = _studentService.GetReportsByUser(_user.UserId);

            dgvReports.DataSource = _reports.Select(r => new
            {
                r.ReportId,
                ExamName = r.Exam.ExamName,
                r.Score,
                Date = r.Date.ToString("g")
            }).ToList();

            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnDownloadPdf_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null)
            {
                MessageBox.Show("Please select a report to download.");
                return;
            }

            int reportId = (int)dgvReports.CurrentRow.Cells["ReportId"].Value;
            var selectedReport = _reports.FirstOrDefault(r => r.ReportId == reportId);

            if (selectedReport == null)
            {
                MessageBox.Show("Report not found.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"ExamReport_{selectedReport.Exam.ExamName}_{selectedReport.Date:yyyyMMdd}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                GeneratePdf(selectedReport, saveDialog.FileName);
                MessageBox.Show("Report downloaded successfully!");
            }
        }

        private void GeneratePdf(Report report, string filePath)
        {
            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                doc.Add(new Paragraph($"Exam Report", titleFont));
                doc.Add(new Paragraph($"Student: {_user.FullName}", bodyFont));
                doc.Add(new Paragraph($"Exam: {report.Exam.ExamName}", bodyFont));
                doc.Add(new Paragraph($"Score: {report.Score}", bodyFont));
                doc.Add(new Paragraph($"Date: {report.Date:g}", bodyFont));
                doc.Add(new Paragraph("-------------------------------------------------------"));
                doc.Add(new Paragraph("Answers:", titleFont));
                doc.Add(new Paragraph(" "));

                // Retrieve all answers related to this report
                var answers = _studentService.GetAnswersByReport(report.ReportId);

                PdfPTable table = new PdfPTable(3);
                table.AddCell("Question");
                table.AddCell("Your Answer");
                table.AddCell("Correct?");

                foreach (var ans in answers)
                {
                    table.AddCell(ans.Questions.Body);
                    table.AddCell(ans.Choice.Body);
                    table.AddCell(ans.IsCorrect ? "Correct" : "Not correct");
                }

                doc.Add(table);
                doc.Close();
                writer.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backPressed= true;
            Close();
        }
    }
}
