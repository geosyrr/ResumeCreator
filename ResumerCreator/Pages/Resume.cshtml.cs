using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ResumerCreator.Pages
{
    public class ResumeModel : PageModel
    {
        public void OnGet()
        {
        }
        public static string HTML = @"<div style=""width:100%;background-color:#ddd""><div style=""width:85%;background-color:white""></div></div>";
        [Obsolete]
        public IActionResult OnPostAsync(object sender, EventArgs e)
        {


            try
            {

                using (MemoryStream ms = new MemoryStream())
                {
                    Document document = new Document(PageSize.A4, -75, -75, 0, 0);
                    PdfWriter writer = PdfWriter.GetInstance(document, ms);
                    // Add meta information to the document
                    document.AddAuthor("Speedex");
                    document.AddCreator("G.Sirrakos");
                    document.AddKeywords("Voucher Label");
                    document.AddSubject("Voucher Label");
                    document.AddTitle("Voucher Label");

                    document.Open();
                    BaseFont Merriweather = BaseFont.CreateFont(@"Fonts/Merriweather-Light.ttf", BaseFont.IDENTITY_H, true);
                    BaseFont Calibri = BaseFont.CreateFont(@"Fonts/Calibri.ttf", BaseFont.IDENTITY_H, true);
                    BaseColor mycolor = WebColors.GetRGBColor("#10365c");
                    Image veryGood = Image.GetInstance(@"Skill_pngs/VeryGood.png");
                    Image average = Image.GetInstance(@"Skill_pngs/Average.png");
                    Image novice = Image.GetInstance(@"Skill_pngs/Novice.png");
                    Image excellent = Image.GetInstance(@"Skill_pngs/Excellent.png");
                    PdfContentByte cb = new PdfContentByte(writer);


                    #region Details - Skills section

                    PdfPCell cell1 = new PdfPCell(new Phrase("Giorgos Sirrakos", new Font(Merriweather, 18, Font.BOLD, BaseColor.WHITE)));
                    cell1.BorderWidth = 0;
                    cell1.PaddingBottom = 10f;
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell cell2 = new PdfPCell(new Phrase("Web Application Developer", new Font(Calibri, 10, Font.NORMAL, BaseColor.WHITE)));
                    cell2.BorderWidth = 0;
                    cell2.PaddingBottom = 15f;
                    cell2.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell cell3 = new PdfPCell(new Phrase("Details", new Font(Merriweather, 13, Font.BOLD, BaseColor.WHITE)));
                    cell3.BorderWidth = 0;
                    cell3.PaddingBottom = 7f;
                    cell3.PaddingLeft = 35f;
                    PdfPCell cell4 = new PdfPCell(new Phrase("6971234567", new Font(Calibri, 10, Font.NORMAL, BaseColor.WHITE)));
                    cell4.BorderWidth = 0;
                    cell4.PaddingBottom = 3f;
                    cell4.PaddingLeft = 35f;
                    var emailAnchor = new Anchor("example@gmail.com", new Font(Calibri, 10, Font.UNDERLINE, BaseColor.WHITE));
                    emailAnchor.Reference = "mailto:example@gmail.com";
                    PdfPCell cell5 = new PdfPCell(emailAnchor);
                    cell5.BorderWidth = 0;
                    cell5.PaddingBottom = 5f;
                    cell5.PaddingLeft = 35f;
                    PdfPCell cell6 = new PdfPCell(new Phrase("Date of Birth", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell6.BorderWidth = 0;
                    cell6.PaddingBottom = 4f;
                    cell6.PaddingLeft = 35f;
                    PdfPCell cell7 = new PdfPCell(new Phrase("04/1992", new Font(Calibri, 10, Font.NORMAL, BaseColor.WHITE)));
                    cell7.BorderWidth = 0;
                    cell7.PaddingBottom = 15f;
                    cell7.PaddingLeft = 35f;
                    PdfPCell cell8 = new PdfPCell(new Phrase("Links", new Font(Merriweather, 13, Font.BOLD, BaseColor.WHITE)));
                    cell8.BorderWidth = 0;
                    cell8.PaddingBottom = 7f;
                    cell8.PaddingLeft = 35f;
                    var linkedIn = new Chunk("LinkedIn", new Font(Calibri, 10, Font.UNDERLINE, BaseColor.WHITE));
                    linkedIn.SetAnchor("https://www.linkedin.com");
                    PdfPCell cell9 = new PdfPCell(new Phrase(linkedIn));
                    cell9.BorderWidth = 0;
                    cell9.PaddingBottom = 2f;
                    cell9.PaddingLeft = 35f;
                    var gitHub = new Chunk("GitHub", new Font(Calibri, 10, Font.UNDERLINE, BaseColor.WHITE));
                    gitHub.SetAnchor("https://www.github.com");
                    PdfPCell cell10 = new PdfPCell(new Phrase(gitHub));
                    cell10.BorderWidth = 0;
                    cell10.PaddingBottom = 15f;
                    cell10.PaddingLeft = 35f;
                    PdfPCell cell11 = new PdfPCell(new Phrase("Languages", new Font(Merriweather, 13, Font.BOLD, BaseColor.WHITE)));
                    cell11.BorderWidth = 0;
                    cell11.PaddingBottom = 7f;
                    cell11.PaddingLeft = 35f;
                    PdfPCell cell12 = new PdfPCell(new Phrase("Greek, English", new Font(Calibri, 10, Font.NORMAL, BaseColor.WHITE)));
                    cell12.BorderWidth = 0;
                    cell12.PaddingBottom = 15f;
                    cell12.PaddingLeft = 35f;
                    PdfPCell cell13 = new PdfPCell(new Phrase("Skills", new Font(Merriweather, 13, Font.BOLD, BaseColor.WHITE)));
                    cell13.BorderWidth = 0;
                    cell13.PaddingBottom = 7f;
                    cell13.PaddingLeft = 35f;
                    PdfPCell cell14 = new PdfPCell(new Phrase(".NET Core, .NET Framework", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell14.BorderWidth = 0;
                    cell14.PaddingBottom = 4f;
                    cell14.PaddingLeft = 35f;
                    PdfPCell cell15 = new PdfPCell(veryGood);
                    cell15.PaddingTop = 5f;
                    cell15.BorderWidth = 0;
                    cell15.PaddingBottom = 5f;
                    cell15.PaddingLeft = 35f;
                    PdfPCell cell16 = new PdfPCell(new Phrase("SQL", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell16.BorderWidth = 0;
                    cell16.PaddingBottom = 4f;
                    cell16.PaddingLeft = 35f;
                    PdfPCell cell17 = new PdfPCell(average);
                    cell17.PaddingTop = 5f;
                    cell17.BorderWidth = 0;
                    cell17.PaddingBottom = 5f;
                    cell17.PaddingLeft = 35f;
                    PdfPCell cell18 = new PdfPCell(new Phrase("HTML, CSS, JavaScript", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell18.BorderWidth = 0;
                    cell18.PaddingBottom = 4f;
                    cell18.PaddingLeft = 35f;
                    PdfPCell cell19 = new PdfPCell(veryGood);
                    cell19.PaddingTop = 5f;
                    cell19.BorderWidth = 0;
                    cell19.PaddingBottom = 5f;
                    cell19.PaddingLeft = 35f;
                    PdfPCell cell20 = new PdfPCell(new Phrase("Java", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell20.BorderWidth = 0;
                    cell20.PaddingBottom = 4f;
                    cell20.PaddingLeft = 35f;
                    PdfPCell cell21 = new PdfPCell(novice);
                    cell21.PaddingTop = 5f;
                    cell21.BorderWidth = 0;
                    cell21.PaddingBottom = 5f;
                    cell21.PaddingLeft = 35f;
                    PdfPCell cell22 = new PdfPCell(new Phrase("CMS(Wordpress,WIX,DNN)", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell22.BorderWidth = 0;
                    cell22.PaddingBottom = 4f;
                    cell22.PaddingLeft = 35f;
                    PdfPCell cell23 = new PdfPCell(veryGood);
                    cell23.PaddingTop = 5f;
                    cell23.BorderWidth = 0;
                    cell23.PaddingBottom = 5f;
                    cell23.PaddingLeft = 35f;
                    PdfPCell cell24 = new PdfPCell(new Phrase("Social Media", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell24.BorderWidth = 0;
                    cell24.PaddingBottom = 4f;
                    cell24.PaddingLeft = 35f;
                    PdfPCell cell25 = new PdfPCell(veryGood);
                    cell25.PaddingTop = 5f;
                    cell25.BorderWidth = 0;
                    cell25.PaddingBottom = 5f;
                    cell25.PaddingLeft = 35f;
                    PdfPCell cell26 = new PdfPCell(new Phrase("Customer Satisfaction", new Font(Calibri, 12, Font.NORMAL, BaseColor.WHITE)));
                    cell26.BorderWidth = 0;
                    cell26.PaddingBottom = 4f;
                    cell26.PaddingLeft = 35f;
                    PdfPCell cell27 = new PdfPCell(excellent);
                    cell27.PaddingTop = 5f;
                    cell27.BorderWidth = 0;
                    cell27.PaddingBottom = 15f;
                    cell27.PaddingLeft = 35f;
                    PdfPCell cell28 = new PdfPCell(new Phrase("Hobbies", new Font(Merriweather, 16, Font.BOLD, BaseColor.WHITE)));
                    cell28.BorderWidth = 0;
                    cell28.PaddingBottom = 5f;
                    cell28.PaddingLeft = 35f;
                    PdfPCell cell29 = new PdfPCell(new Phrase("TRX training, Football, Drawing,\nConsole Gaming,Travels,\nVolunteer, Coffee Addicted. ", new Font(Calibri, 10, Font.NORMAL, BaseColor.WHITE)));
                    cell29.BorderWidth = 0;
                    cell29.PaddingBottom = 12f;
                    cell29.PaddingLeft = 35f;
                    cell29.FixedHeight = 274f;


                    PdfPTable table1 = new PdfPTable(1);
                    table1.AddCell(cell1);
                    table1.AddCell(cell2);
                    table1.AddCell(cell3);
                    table1.AddCell(cell4);
                    table1.AddCell(cell5);
                    table1.AddCell(cell6);
                    table1.AddCell(cell7);
                    table1.AddCell(cell8);
                    table1.AddCell(cell9);
                    table1.AddCell(cell10);
                    table1.AddCell(cell11);
                    table1.AddCell(cell12);
                    table1.AddCell(cell13);
                    table1.AddCell(cell14);
                    table1.AddCell(cell15);
                    table1.AddCell(cell16);
                    table1.AddCell(cell17);
                    table1.AddCell(cell18);
                    table1.AddCell(cell19);
                    table1.AddCell(cell20);
                    table1.AddCell(cell21);
                    table1.AddCell(cell22);
                    table1.AddCell(cell23);
                    table1.AddCell(cell24);
                    table1.AddCell(cell25);
                    table1.AddCell(cell26);
                    table1.AddCell(cell27);
                    table1.AddCell(cell28);
                    table1.AddCell(cell29);

                    PdfPCell pdfPCellTable1 = new PdfPCell(table1);
                    pdfPCellTable1.BorderWidth = 0;
                    pdfPCellTable1.BackgroundColor = mycolor;
                    pdfPCellTable1.PaddingRight = 15f;
                    pdfPCellTable1.PaddingTop = 38f;
                    #endregion

                    #region Profile section

                    PdfPCell cell1b = new PdfPCell(new Phrase("PERSONAL SUMMARY", new Font(Merriweather, 14, Font.BOLD)));
                    cell1b.PaddingBottom = 7f;
                    cell1b.BorderWidth = 0;
                    PdfPCell cell2b = new PdfPCell(new Phrase("Experienced Web Developer adept at all stages of advanced web development." +
                        " Knowledgeable in user interface, testing, and debugging processes." +
                        " Equipped with a diverse and promising skill-set." +
                        " Proficient in an assortment of technologies, including  ASP.NET Framework, .Net Core, C#,\nIIS packages and Microsoft SQL Server."
                        , new Font(Calibri, 11, Font.NORMAL)));
                    cell2b.PaddingBottom = 15f;
                    cell2b.BorderWidth = 0;
                    PdfPCell cell3b = new PdfPCell(new Phrase("EMPLOYMENT HISTORY", new Font(Merriweather, 14, Font.BOLD)));
                    cell3b.PaddingBottom = 7f;
                    cell3b.BorderWidth = 0;
                    PdfPCell cell4b = new PdfPCell(new Phrase(".NET application developer, Speedex S.A ", new Font(Calibri, 12, Font.NORMAL)));
                    cell4b.PaddingBottom = 2f;
                    cell4b.BorderWidth = 0;
                    PdfPCell cell5b = new PdfPCell(new Phrase("September 2020 - Present | Kifissia", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell5b.PaddingBottom = 3f;
                    cell5b.BorderWidth = 0;
                    PdfPCell cell6b = new PdfPCell(new Phrase("• Web Applications Developer\n• .Net Framework / .Net Core / C# / Razor Pages / MVC\n• SOAP and REST API Integration\n• SSIS Packages\n• SQL scripts (SSMS)\n• IT Support\n• Planned, developed, tested, deployed, and maintained web applications", new Font(Calibri, 11, Font.NORMAL)));
                    cell6b.PaddingBottom = 10f;
                    cell6b.BorderWidth = 0;
                    cell6b.PaddingLeft = 15f;
                    PdfPCell cell7b = new PdfPCell(new Phrase("Consumer - IT department, Plaisio Computers AEBE ", new Font(Calibri, 12, Font.NORMAL)));
                    cell7b.PaddingBottom = 2f;
                    cell7b.BorderWidth = 0;
                    PdfPCell cell8b = new PdfPCell(new Phrase("May 2020 - September 2020 | Metamorfosi", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell8b.PaddingBottom = 3f;
                    cell8b.BorderWidth = 0;
                    PdfPCell cell9b = new PdfPCell(new Phrase("• SAP/CRM electronic data processing\n• Sales and Customer Support", new Font(Calibri, 11, Font.NORMAL)));
                    cell9b.PaddingBottom = 10f;
                    cell9b.BorderWidth = 0;
                    cell9b.PaddingLeft = 15f;
                    PdfPCell cell10b = new PdfPCell(new Phrase("Customer support - EODY department, Teleperformance SE ", new Font(Calibri, 12, Font.NORMAL)));
                    cell10b.PaddingBottom = 2f;
                    cell10b.BorderWidth = 0;
                    PdfPCell cell11b = new PdfPCell(new Phrase("Mar 2020 - May 2020 | Moschato", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell11b.PaddingBottom = 15f;
                    cell11b.BorderWidth = 0;
                    PdfPCell cell12b = new PdfPCell(new Phrase("Restaurant manager & assistant accountant, Juicy Grill", new Font(Calibri, 12, Font.NORMAL)));
                    cell12b.PaddingBottom = 3f;
                    cell12b.BorderWidth = 0;
                    PdfPCell cell13b = new PdfPCell(new Phrase("May 2016 - Oct 2019 | Cholargos", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell13b.PaddingBottom = 15f;
                    cell13b.BorderWidth = 0;
                    PdfPCell cell14b = new PdfPCell(new Phrase("E-shop operator, Zoe Apostolou", new Font(Calibri, 12, Font.NORMAL)));
                    cell14b.PaddingBottom = 3f;
                    cell14b.BorderWidth = 0;
                    PdfPCell cell15b = new PdfPCell(new Phrase("Sep 2013 - Aug 2014 | Athens", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell15b.PaddingBottom = 15f;
                    cell15b.BorderWidth = 0;
                    PdfPCell cell16b = new PdfPCell(new Phrase("Assistant accountant, ERT International ", new Font(Calibri, 12, Font.NORMAL)));
                    cell16b.PaddingBottom = 3f;
                    cell16b.BorderWidth = 0;
                    PdfPCell cell17b = new PdfPCell(new Phrase("Sep 2010 - Jun 2012 | Ag.Paraskevi", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell17b.PaddingBottom = 15f;
                    cell17b.BorderWidth = 0;

                    PdfPCell cell18b = new PdfPCell(new Phrase("EDUCATION", new Font(Merriweather, 14, Font.BOLD)));
                    cell18b.PaddingBottom = 7f;
                    cell18b.BorderWidth = 0;
                    PdfPCell cell19b = new PdfPCell(new Phrase("Android apps development, part of Project Future by Piraeus Bank, powered by Code.Hub & ReGeneration Academy ", new Font(Calibri, 12, Font.NORMAL)));
                    cell19b.PaddingBottom = 3f;
                    cell19b.BorderWidth = 0;
                    PdfPCell cell20b = new PdfPCell(new Phrase("Apr 2020 - Jun 2020", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell20b.PaddingBottom = 3f;
                    cell20b.BorderWidth = 0;
                    PdfPCell cell20a = new PdfPCell(new Phrase("• Implemenation of a mobile application\n• Java/API understandings\n• Agile Coordination", new Font(Calibri, 11, Font.NORMAL)));
                    cell20a.PaddingBottom = 10f;
                    cell20a.BorderWidth = 0;
                    cell20a.PaddingLeft = 15f;
                    PdfPCell cell21b = new PdfPCell(new Phrase(".NET web development, Collegelink ", new Font(Calibri, 12, Font.NORMAL)));
                    cell21b.PaddingBottom = 3f;
                    cell21b.BorderWidth = 0;
                    PdfPCell cell22b = new PdfPCell(new Phrase("Jan 2020 - Mar 2020", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell22b.PaddingBottom = 3f;
                    cell22b.BorderWidth = 0;
                    PdfPCell cell23b = new PdfPCell(new Phrase("• .Net Framework and C# understanding\n• HTML/CSS/JavaScript(jQuery) and SQL Database", new Font(Calibri, 11, Font.NORMAL)));
                    cell23b.PaddingBottom = 10f;
                    cell23b.BorderWidth = 0;
                    cell23b.PaddingLeft = 15f;
                    PdfPCell cell24b = new PdfPCell(new Phrase("Computer system support technician, EPAS Heraklion Attica ", new Font(Calibri, 12, Font.NORMAL)));
                    cell24b.PaddingBottom = 3f;
                    cell24b.BorderWidth = 0;
                    PdfPCell cell25b = new PdfPCell(new Phrase("Sep 2010 - Jun 2010", new Font(Calibri, 9, Font.NORMAL, BaseColor.GRAY)));
                    cell25b.PaddingBottom = 3f;
                    cell25b.BorderWidth = 0;
                    PdfPCell cell26b = new PdfPCell(new Phrase("• Installation, support and upgrade of software system and applications\n• Utilizing Internet programming tools and basic Internet services\n• Local area network (LAN) equipment and software management", new Font(Calibri, 11, Font.NORMAL)));
                    cell26b.PaddingBottom = 10f;
                    cell26b.BorderWidth = 0;
                    cell26b.PaddingLeft = 15f;

                    PdfPTable table2 = new PdfPTable(1);
                    table2.AddCell(cell1b);
                    table2.AddCell(cell2b);
                    table2.AddCell(cell3b);
                    table2.AddCell(cell4b);
                    table2.AddCell(cell5b);
                    table2.AddCell(cell6b);
                    table2.AddCell(cell7b);
                    table2.AddCell(cell8b);
                    table2.AddCell(cell9b);
                    table2.AddCell(cell10b);
                    table2.AddCell(cell11b);
                    table2.AddCell(cell12b);
                    table2.AddCell(cell13b);
                    table2.AddCell(cell14b);
                    table2.AddCell(cell15b);
                    table2.AddCell(cell16b);
                    table2.AddCell(cell17b);
                    table2.AddCell(cell18b);
                    table2.AddCell(cell19b);
                    table2.AddCell(cell20b);
                    table2.AddCell(cell20a);
                    table2.AddCell(cell21b);
                    table2.AddCell(cell22b);
                    table2.AddCell(cell23b);
                    table2.AddCell(cell24b);
                    table2.AddCell(cell25b);
                    table2.AddCell(cell26b);


                    PdfPCell pdfPCellTable2 = new PdfPCell(table2);
                    pdfPCellTable2.BorderWidth = 0;
                    pdfPCellTable2.PaddingRight = 20f;
                    pdfPCellTable2.PaddingLeft = 20f;
                    pdfPCellTable2.PaddingTop = 39f;

                    #endregion

                    PdfPTable pdfPMainTable = new PdfPTable(2);
                    pdfPMainTable.AddCell(pdfPCellTable1);
                    pdfPMainTable.AddCell(pdfPCellTable2);
                    float[] mainTableWidths = new float[] { 300f, 600f };
                    pdfPMainTable.SetWidths(mainTableWidths);


                    document.Add(pdfPMainTable);

                    document.Close();
                    return File(ms.ToArray(), "application/pdf", "Resume.pdf");
                }

            }
            catch (Exception ex)
            {

            }
            return Page();
}
    }
}
