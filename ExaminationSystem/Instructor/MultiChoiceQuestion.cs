using BL.Services;
using Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Instructor;
public partial class MultiChoiceQuestion : Form
{
    private readonly IServiceProvider _serviceProvider;

    private readonly ITeacher _context;
    private readonly User _user;
    private readonly Exam _exam;
    private string _questionType = "Choose MultiChoise";
    public bool backPressed = false;

    public MultiChoiceQuestion(ITeacher context, IServiceProvider serviceProvider, User user, Exam exam)
    {
        _context = context;
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _user = user;
        _exam = exam;
    }
}
