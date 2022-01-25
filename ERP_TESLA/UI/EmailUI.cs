using ERP_TESLA.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_TESLA.UI
{
    public partial class EmailUI : Form
    {
        public EmailUI()
        {
            InitializeComponent();
        }

        // myaccount.google.com/security 에서 보안 수준이 낮은 앱의 액세스 사용으로 변경해야 발송 가능
        private void FileMailSend(string mailFrom, string pw,string mailTo ,
            string title, string msg, string filePath)
        {
            MailMessage mail = new MailMessage();
            //보내는 사람 이메일
            mail.From = new MailAddress(mailFrom);

            //받는사람 이메일
            mail.To.Add(mailTo);
            //메일제목
            mail.Subject = title;
            //메일내용
            mail.Body = msg;

            //첨부파일
            System.Net.Mail.Attachment attachment;

            //첨부파일 붙이기
            attachment = new System.Net.Mail.Attachment(filePath);
            mail.Attachments.Add(attachment);

            //gmail 포트 설정
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            //SSL 설정 (gmail 은 ture로 설정, 메일 서버 세팅에 따라 다름)
            smtp.EnableSsl = true;

            //gamil 인증을 위한 id/pw (보내는사람 정보 넣기)
            smtp.Credentials = new NetworkCredential(mailFrom, pw);
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                MessageBox.Show("메일발송실패");
            }
        }

        private void EmailUI_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxSendby.Text = string.Empty;
            tboxPW.Text = string.Empty;
            tboxSendTo.Text = string.Empty;
            tboxAttach.Text = string.Empty;
            tboxTitle.Text = string.Empty;
            tboxContents.Text = string.Empty;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog pFileDlg = new OpenFileDialog();
            pFileDlg.Title = "첨부파일 파일을 선택 해주세요.";
            if (pFileDlg.ShowDialog() == DialogResult.OK)
            {
                String strFullPathFile = pFileDlg.FileName;
                tboxAttach.Text = strFullPathFile;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            FileMailSend(tboxSendby.Text, tboxPW.Text,
            tboxSendTo.Text, tboxTitle.Text, tboxContents.Text, tboxAttach.Text);
            this.Close();
        }

        private void btnSearchSendTo_Click(object sender, EventArgs e)
        {
        }
    }
}
