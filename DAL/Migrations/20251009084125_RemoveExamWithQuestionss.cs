using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveExamWithQuestionss : Migration
    {
       
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                // 1️⃣ حذف العلاقة القديمة بين Questions و Exams
                migrationBuilder.DropForeignKey(
                    name: "FK_Questions_Exams_ExamId",
                    table: "Questions");

                // 2️⃣ إضافة العلاقة الجديدة بـ Cascade Delete
                migrationBuilder.AddForeignKey(
                    name: "FK_Questions_Exams_ExamId",
                    table: "Questions",
                    column: "ExamId",
                    principalTable: "Exams",
                    principalColumn: "ExamId",
                    onDelete: ReferentialAction.Cascade);

                // 3️⃣ حذف العلاقة القديمة بين Choices و Questions
                migrationBuilder.DropForeignKey(
                    name: "FK_Choices_Questions_QuestionId",
                    table: "Choices");

                // 4️⃣ إضافة العلاقة الجديدة بـ Cascade Delete
                migrationBuilder.AddForeignKey(
                    name: "FK_Choices_Questions_QuestionId",
                    table: "Choices",
                    column: "QuestionId",
                    principalTable: "Questions",
                    principalColumn: "QuestionsId",
                    onDelete: ReferentialAction.Cascade);
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                // التراجع عن التغييرات (إرجاعها NoAction)

                migrationBuilder.DropForeignKey(
                    name: "FK_Questions_Exams_ExamId",
                    table: "Questions");

                migrationBuilder.AddForeignKey(
                    name: "FK_Questions_Exams_ExamId",
                    table: "Questions",
                    column: "ExamId",
                    principalTable: "Exams",
                    principalColumn: "ExamId",
                    onDelete: ReferentialAction.NoAction);

                migrationBuilder.DropForeignKey(
                    name: "FK_Choices_Questions_QuestionId",
                    table: "Choices");

                migrationBuilder.AddForeignKey(
                    name: "FK_Choices_Questions_QuestionId",
                    table: "Choices",
                    column: "QuestionId",
                    principalTable: "Questions",
                    principalColumn: "QuestionsId",
                    onDelete: ReferentialAction.NoAction);
            }
        }

    
}
