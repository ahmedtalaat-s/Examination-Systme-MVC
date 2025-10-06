using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserSubjectAndExamMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSubject_Subject_SubjectId",
                table: "UserSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubject_User_UserId",
                table: "UserSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTakeExam_Exams_ExamId",
                table: "UserTakeExam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTakeExam_User_UserId",
                table: "UserTakeExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTakeExam",
                table: "UserTakeExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubject",
                table: "UserSubject");

            migrationBuilder.RenameTable(
                name: "UserTakeExam",
                newName: "UserExams");

            migrationBuilder.RenameTable(
                name: "UserSubject",
                newName: "UserSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_UserTakeExam_ExamId",
                table: "UserExams",
                newName: "IX_UserExams_ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubject_UserId",
                table: "UserSubjects",
                newName: "IX_UserSubjects_UserId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsCorrect",
                table: "StudentAnswers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExams",
                table: "UserExams",
                columns: new[] { "UserId", "ExamId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubjects",
                table: "UserSubjects",
                columns: new[] { "SubjectId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserExams_Exams_ExamId",
                table: "UserExams",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExams_User_UserId",
                table: "UserExams",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubjects_Subject_SubjectId",
                table: "UserSubjects",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubjects_User_UserId",
                table: "UserSubjects",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserExams_Exams_ExamId",
                table: "UserExams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExams_User_UserId",
                table: "UserExams");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubjects_Subject_SubjectId",
                table: "UserSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubjects_User_UserId",
                table: "UserSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubjects",
                table: "UserSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExams",
                table: "UserExams");

            migrationBuilder.RenameTable(
                name: "UserSubjects",
                newName: "UserSubject");

            migrationBuilder.RenameTable(
                name: "UserExams",
                newName: "UserTakeExam");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubjects_UserId",
                table: "UserSubject",
                newName: "IX_UserSubject_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserExams_ExamId",
                table: "UserTakeExam",
                newName: "IX_UserTakeExam_ExamId");

            migrationBuilder.AlterColumn<int>(
                name: "IsCorrect",
                table: "StudentAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubject",
                table: "UserSubject",
                columns: new[] { "SubjectId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTakeExam",
                table: "UserTakeExam",
                columns: new[] { "UserId", "ExamId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubject_Subject_SubjectId",
                table: "UserSubject",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubject_User_UserId",
                table: "UserSubject",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTakeExam_Exams_ExamId",
                table: "UserTakeExam",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTakeExam_User_UserId",
                table: "UserTakeExam",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
