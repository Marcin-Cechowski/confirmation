using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Layout.Borders;
using iText.IO.Font.Constants;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Data;

namespace PdfGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string dest = "C:\\Users\\ForTh\\Documents\\Confirmation_of_Deliverable_Forward_Transaction.pdf";
            string dest2 = "C:\\Users\\ForTh\\Documents\\kk\\abc.pdf";
            //PDFInspector.GetMargins(dest2);
            PdfWriter writer = new PdfWriter(dest);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.A4);



            PdfFont font = PdfFontFactory.CreateFont("C:\\Users\\ForTh\\Documents\\Times New Roman.ttf");
            PdfFont boldFont = PdfFontFactory.CreateFont("C:\\Users\\ForTh\\Documents\\Times New Roman.ttf");

            document.SetFont(font).SetFontSize(11);
            document.SetMargins(72, 78.98285f, 75.584f, 70.824f);

            // Add content for Part 1 - Title and Letterhead
            document.Add(new Paragraph("Exhibit 1. Confirmation of a Deliverable Forward Transaction")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold());
            document.Add(new Paragraph("Додаток 1. Підтвердження Правочину Поставний Форвард")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBold());

            // Insert space
            document.Add(new Paragraph("\n [On the letterhead of Party A] / [на бланку Сторони А]")
                .SetTextAlignment(TextAlignment.CENTER));

            document.Add(new Paragraph("dated [●] / від [●] року")
                .SetTextAlignment(TextAlignment.JUSTIFIED));
            document.Add(new Paragraph("Re: [Name of a Transaction] / Тема: [Назва Правочину]")
                .SetTextAlignment(TextAlignment.JUSTIFIED));



            Table table = new Table(3);
            Table table2 = new Table(3);
            Table table3 = new Table(3);
            Table table4 = new Table(2);
            Table table5 = new Table(3);

            table.SetWidth(UnitValue.CreatePercentValue(100)); // Full width of the page
            table2.SetWidth(UnitValue.CreatePercentValue(100));
            table3.SetWidth(UnitValue.CreatePercentValue(100));
            table4.SetWidth(UnitValue.CreatePercentValue(100));
            table5.SetWidth(UnitValue.CreatePercentValue(100));
            // Create the left and right cells with the text you want side by side
            Cell leftCell = new Cell().Add(new Paragraph("\n The purpose of this letter (the \"Confirmation\") is\r\nto confirm the terms and conditions of the\r\nTransaction entered into between us on the Trade\r\nDate specified below (the \"Transaction\"). This\r\nConfirmation constitutes a \"Confirmation\" as\r\ndefined in the Master Agreement specified below.").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);

            Cell rightCell = new Cell().Add(new Paragraph("\n Цим листом (далі – \"Підтвердження\")\r\nпідтверджуються умови Правочину,\r\nукладеного нами у Дату Правочину,\r\nзазначену нижче (далі – \"Правочин\"). Це\r\nПідтвердження становить \"Підтвердження\"\r\nяк визначено в Генеральній Угоді,").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph ukrParagraph1 = new Paragraph("зазначеній нижче.").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);

            rightCell.Add(ukrParagraph1);
            // Add cells to the table
            table.AddCell(leftCell);
            table.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table.AddCell(rightCell);


            Cell leftCell2 = new Cell().Add(new Paragraph("\n The definitions and provisions contained in the\r\nDerivative Transactions Definitions are\rincorporated into this Confirmation. In the event of\rany inconsistency between those definitions and\rprovisions and this Confirmation, this").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);

            Cell rightCell2 = new Cell().Add(new Paragraph("\n Визначення та умови, що містяться у\r\nТипових Умовах Деривативних Правочинів\r\nскладають частину цього Підтвердження. У\r\nвипадку будь-яких розбіжностей між\r\nумовами цього Підтвердження та Типовими\r\nУмовами, положення цього Підтвердження.").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            
            Paragraph engParagraph1 = new Paragraph("Confirmation will prevail.").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            Paragraph ukrParagraph2 = new Paragraph("мають вищу юридичну силу").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);

            leftCell2.Add(engParagraph1);
            rightCell2.Add(ukrParagraph2);

            table2.AddCell(leftCell2);
            table2.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table2.AddCell(rightCell2);

            Cell leftCell3 = new Cell().Add(new Paragraph("\n This Confirmation supplements, forms а part of,\r\nand is subject to Master Agreement [●] dated [●],\r\nas amended and supplemented (\"Master\r\nAgreement\"), entered into between [●]\r\n(\"Party A\") and [●] (\"Party B\", and Party B and\r\nParty A are collectively referred to as the\r\n\"Parties\"). All provisions contained in the Master\r\nAgreement govern this Confirmation except as\r\nexpressly modified below. The terms of the\r\nTransaction to which this Confirmation relates are").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Cell rightCell3 = new Cell().Add(new Paragraph("\n Це Підтвердження доповнює та\r\nрегулюється умовами Генеральної Угоди\r\n[●] від [●], зі змінами та доповненнями\r\n(\"Генеральна Угода\"), укладеної між [●]\r\n(АТ Сітібанк та [●] (\"Сторона Б\", а разом\r\nСторона Б зі Стороною А – \"Сторони\"). Усі\r\nположення Генеральної Угоди\r\nзастосовуються до цього Підтвердження,\r\nокрім випадків, коли вони безпосередньо\r\nзмінені нижче. Сторони погодили такі\r\nумови Правочину, якого стосується").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            
            Paragraph engParagraph2 = new Paragraph("as follows:").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            Paragraph ukrParagraph3 = new Paragraph("Підтвердження:").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);

            leftCell3.Add(engParagraph2);
            rightCell3.Add(ukrParagraph3);

            table3.AddCell(leftCell3);
            table3.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table3.AddCell(rightCell3);

            // Add the table to the document
            document.Add(table);
            document.Add(table2);
            document.Add(table3);


            Paragraph paragraph = new Paragraph();
            
            Paragraph emptyParagraph = new Paragraph();


            TabStop generalInfoTabLeft = new TabStop(20, TabAlignment.LEFT);
            TabStop generalInfoTabRight = new TabStop(20, TabAlignment.RIGHT);

            document.Add(emptyParagraph);
            document.Add(emptyParagraph);
            document.Add(emptyParagraph);

            paragraph.AddTabStops(generalInfoTabLeft).SetBold();

            // Add text with two tabs to move the text by two tab stops
            Cell emptyCell = new Cell().SetBorder(Border.NO_BORDER);
            
            paragraph.Add(new Tab()) 
                     .Add("General Terms / Загальні умови");
            Cell leftCell4 = new Cell().Add(paragraph.Add(new Tab()).SetMultipliedLeading(3.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //General info left collumns
            Paragraph tradeDate = new Paragraph();
            tradeDate.AddTabStops(generalInfoTabLeft);
            tradeDate.Add(new Tab())
                     .Add("Trade Date / Дата Правочину:");

            Cell leftCell5 = new Cell().Add(tradeDate.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            //General info right collumns
            Paragraph testTextRight = new Paragraph();
            testTextRight.Add("[insert text/додати текст]");

            Cell rightCell4 = new Cell().Add(testTextRight).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            //end

            Paragraph tradeDate2 = new Paragraph();
            tradeDate2.AddTabStops(generalInfoTabLeft);
            tradeDate2.Add(new Tab())
                     .Add("Currency Pair / Валютна Пара:");

            Cell leftCell6 = new Cell().Add(tradeDate2.Add(new Tab()).SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            Paragraph testTextRight2 = new Paragraph();
            testTextRight2.Add("[insert text/додати текст]");

            Cell rightCell5 = new Cell().Add(testTextRight2).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            Paragraph tradeDate3 = new Paragraph();
            tradeDate3.AddTabStops(generalInfoTabLeft);
            tradeDate3.Add("[Amount and currency payable by Party A]/\r\n[Сума та валюта, що підлягають сплаті\r\nСтороною А:]");

            tradeDate3.SetMarginLeft(20);

            Cell leftCell7 = new Cell().Add(tradeDate3.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph testTextRight3 = new Paragraph();
            testTextRight3.Add("[insert text/додати текст]");

            Cell rightCell6 = new Cell().Add(testTextRight3).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            Paragraph tradeDate4 = new Paragraph();
            tradeDate4.AddTabStops(generalInfoTabLeft);
            tradeDate4.Add("[Amount and currency payable by Party B or\r\nthe Forward Rate]/ [Сума та валюта, що\r\n підлягають сплаті Стороною Б або\r\nФорвардний Курс:]");

            tradeDate4.SetMarginLeft(20);

            Cell leftCell8 = new Cell().Add(tradeDate4.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight4 = new Paragraph();
            testTextRight4.Add("[insert text/додати текст]");

            Cell rightCell7 = new Cell().Add(testTextRight4).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            Paragraph tradeDate5 = new Paragraph();
            tradeDate5.AddTabStops(generalInfoTabLeft);
            tradeDate5.Add("Settlement Date / Дата Розрахунків:");

            tradeDate5.SetMarginLeft(20);

            Cell leftCell9 = new Cell().Add(tradeDate5.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph settlement = new Paragraph();
            settlement.Add("[insert text/додати текст]");

            Cell rightCellFixed = new Cell().Add(settlement).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            Paragraph paragraph2v2 = new Paragraph();
            paragraph2v2.AddTabStops(generalInfoTabLeft).SetBold();
            paragraph2v2.Add(new Tab())
                .Add("[Other terms:] / [Інші умови:]");
            Cell otherTerms = new Cell().Add(paragraph2v2.Add(new Tab()).SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);



            Paragraph tradeDate6 = new Paragraph();
            tradeDate6.AddTabStops(generalInfoTabLeft);
            tradeDate6.Add("Calculation Agent: / Агент з Розрахунків");

            tradeDate6.SetMarginLeft(20);

            Cell leftCell10 = new Cell().Add(tradeDate6.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight6 = new Paragraph();
            testTextRight6.Add("[insert text/додати текст]");

            Cell rightCell9 = new Cell().Add(testTextRight6).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph tradeDate7 = new Paragraph();
            tradeDate7.AddTabStops(generalInfoTabLeft);
            tradeDate7.Add("Bank details of Party А: / Банківські\r\nреквізити Сторони А (CS requisites)");

            tradeDate7.SetMarginLeft(20);

            Cell leftCell11 = new Cell().Add(tradeDate7.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight7 = new Paragraph();
            testTextRight7.Add("[insert text/додати текст]");

            Cell rightCell10 = new Cell().Add(testTextRight7).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph tradeDate8 = new Paragraph();
            tradeDate8.AddTabStops(generalInfoTabLeft);
            tradeDate8.Add("Bank details of Party B for debiting funds from\r\nits account / Банківські реквізити Сторони Б\r\nдля списання коштів з рахунку:");

            tradeDate8.SetMarginLeft(20);

            Cell leftCell12 = new Cell().Add(tradeDate8.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight8 = new Paragraph();
            testTextRight8.Add("[insert text/додати текст]");

            Cell rightCell11 = new Cell().Add(testTextRight8).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph tradeDate9 = new Paragraph();
            tradeDate9.AddTabStops(generalInfoTabLeft);
            tradeDate9.Add("Bank details of Party B for crediting funds to\r\nits account / Банківські реквізити Сторони Б\r\nдля зарахування коштів на рахунок:");

            tradeDate9.SetMarginLeft(20);

            Cell leftCell13 = new Cell().Add(tradeDate9.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight9 = new Paragraph();
            testTextRight9.Add("[insert text/додати текст]");

            Cell rightCell12 = new Cell().Add(testTextRight9).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph tradeDate10 = new Paragraph();
            tradeDate10.AddTabStops(generalInfoTabLeft);
            tradeDate10.Add("Business Day: / Робочий День: (N/A for\r\nFWD) NDF – Next Day");

            tradeDate10.SetMarginLeft(20);

            Cell leftCell14 = new Cell().Add(tradeDate10.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight11 = new Paragraph();
            testTextRight11.Add("[insert text/додати текст]");

            Cell rightCell13 = new Cell().Add(testTextRight11).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            Paragraph tradeDate11 = new Paragraph();
            tradeDate11.AddTabStops(generalInfoTabLeft);
            tradeDate11.Add("Purpose and reference to the documents, which\r\nconstitute a ground for the purchase of foreign\r\ncurrency (if required by the Law of Ukraine)/\r\nМета та посилання на документи, що є\r\nпідставою для придбання валюти (якщо\r\nвимагається відповідно до законодавства\r\nУкраїни);");

            tradeDate11.SetMarginLeft(20);

            Cell leftCell15 = new Cell().Add(tradeDate11.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER).SetPaddingBottom(10);


            Paragraph testTextRight12 = new Paragraph();
            testTextRight12.Add("[insert text/додати текст]");

            Cell rightCell14 = new Cell().Add(testTextRight12).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            //LAST PART
            Cell leftCellLast1 = new Cell().Add(new Paragraph("\nThis Confirmation executed by Party B is also ").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph helpParagraph = new Paragraph("an Application and supersedes and replaces any\r\nother confirmation (including а phone\r\nconfirmation) if any, sent in connection with\r\n thisTransaction on or prior to the date specified").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph helpParagraph2 = new Paragraph("hereof (if applicable).").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            leftCellLast1.Add(helpParagraph);
            leftCellLast1.Add(helpParagraph2);

            Cell rightCellLast1 = new Cell().Add(new Paragraph("\n Це Підтвердження, підписане Стороною Б, є\r\nтакож Заявою, та замінює будь-яке інше\r\nпідтвердження (включаючи телефонне\r\nпідтвердження), яке було надіслане у зв'язку").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph ukrParagraphLast1 = new Paragraph("з Підтвердженні (у разі наявності).").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            Paragraph helpParagraph1 = new Paragraph("цим Правочином до дати, зазначеної у цьому").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            rightCellLast1.Add(helpParagraph1);
            rightCellLast1.Add(ukrParagraphLast1);
            // Add cells to the table
            table5.AddCell(leftCellLast1);
            table5.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table5.AddCell(rightCellLast1);



            Cell leftCellLast2 = new Cell().Add(new Paragraph("\n By signing this Confirmation, Party B consents\r\nto carrying out by Party A of direct debiting and\r\nconducting the relevant payment transaction for\r\ndebiting Party B's account by Party A, as set out").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph xdParagraph = new Paragraph("in the Schedule to the Master Agreement").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            //Paragraph xdParagraph1 = new Paragraph("hereof (if applicable).").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            leftCellLast2.Add(xdParagraph);
            //leftCellLast1.Add(helpParagraph2);

            Cell rightCellLast2 = new Cell().Add(new Paragraph("\n Підписанням цього Підтвердження Сторона Б ").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph xdParagraph2 = new Paragraph("надає свою згоду на здійснення Стороною А").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph xdParagraph4 = new Paragraph("передбачено Додатком до Генеральної Угоди.").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            Paragraph xdParagraph3 = new Paragraph("договірного списання та виконання\r\nвідповідної платіжної операції з дебетування\r\nрахунку Сторони Б Стороною А, як це").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            rightCellLast2.Add(xdParagraph2);
            rightCellLast2.Add(xdParagraph3);
            rightCellLast2.Add(xdParagraph4);


            Cell leftCellLast3 = new Cell().Add(new Paragraph("\n Please confirm that the foregoing correctly sets\r\nforth the terms of the Transaction by executing\r\nthe сору of this Confirmation enclosed for that\r\npurpose and returning it to us[ or by sending to\r\nus а letter substantially similar to this letter\r\n which letter sets forth the material terms of the\r\nTransaction to which this Confirmation relates\r\nand indicates your agreement to those terms].").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            Paragraph xddParagraph = new Paragraph("in the Schedule to the Master Agreement").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            //Paragraph xdParagraph1 = new Paragraph("hereof (if applicable).").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            //leftCellLast3.Add(xdParagraph);
            //leftCellLast1.Add(helpParagraph2);

            Cell rightCellLast3 = new Cell().Add(new Paragraph("\n Просимо підтвердити те, що вищезазначене\r\nналежним чином визначає умови Правочину,\r\nпідписавши Підтвердження, що додається, і\r\nнадіславши нам його[ або інший лист, який\r\nзагальною мірою відповідає умовам цього\r\nлиста і визначає істотні умови Правочину,\r\nщодо якого видане це Підтвердження].").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            //Paragraph xddParagraph2 = new Paragraph("надає свою згоду на здійснення Стороною А").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            //Paragraph xddParagraph4 = new Paragraph("передбачено Додатком до Генеральної Угоди.").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            //Paragraph xddParagraph3 = new Paragraph("договірного списання та виконання\r\nвідповідної платіжної операції з дебетування\r\nрахунку Сторони Б Стороною А, як це").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED_ALL).SetBorder(Border.NO_BORDER);
            //rightCellLast3.Add(xddParagraph2);
            //rightCellLast2.Add(xddParagraph4);
            //rightCellLast2.Add(xddParagraph3);


            Cell leftCellLast4 = new Cell().Add(new Paragraph("\n Email address for sending the executed copy of\r\nthis Confirmation, if executed with a qualified\r\nelectronic signature  /  Адреса електронної\r\nпошти для відправки підписаного примірника ").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
           Paragraph xdddParagraph = new Paragraph("цього Підтвердження, якщо підписується з\r\nвикористанням кваліфікованого \r\nелектронного підпису:").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            //Paragraph xdParagraph1 = new Paragraph("hereof (if applicable).").SetMultipliedLeading(1.0f).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            //leftCellLast3.Add(xdParagraph);
            //leftCellLast1.Add(helpParagraph2);
            leftCellLast4.Add(xdddParagraph);
            Cell rightCellLast4 = new Cell().Add(new Paragraph("\n [insert email address/додати адресу\r\nелектронної пошти]").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);

            Cell leftCellLast5 = new Cell().Add(new Paragraph("[Signature page / Сторінка з підписами]").SetMultipliedLeading(1.0f)).SetFont(font).SetTextAlignment(TextAlignment.JUSTIFIED).SetBorder(Border.NO_BORDER);
            // rightCellLast1.Add(ukrParagraphLast1);
            // Add cells to the table
            table5.AddCell(leftCellLast1);
            table5.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table5.AddCell(rightCellLast1);

            table5.AddCell(leftCellLast2);
            table5.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table5.AddCell(rightCellLast2);

            table5.AddCell(leftCellLast3);
            table5.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table5.AddCell(rightCellLast3);

            table5.AddCell(leftCellLast4);
            table5.AddCell(new Cell().SetBorder(Border.NO_BORDER));
            table5.AddCell(rightCellLast4);

            table5.AddCell(leftCellLast5);





            //Paragraph tradeDate6 = new Paragraph();
            //tradeDate6.AddTabStops(generalInfoTabLeft);
            //tradeDate6.Add("Calculation Agent: / Агент з Розрахунків");

            //tradeDate6.SetMarginLeft(20);

            //Cell leftCell10 = new Cell().Add(tradeDate6.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph testTextRight6 = new Paragraph();
            //testTextRight6.Add("[insert text/додати текст]");

            //Cell rightCell9 = new Cell().Add(testTextRight6.SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            //Paragraph tradeDate6 = new Paragraph();
            //tradeDate6.AddTabStops(generalInfoTabLeft);
            //tradeDate6.Add("Calculation Agent: / Агент з Розрахунків");

            //tradeDate6.SetMarginLeft(20);

            //Cell leftCell10 = new Cell().Add(tradeDate6.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph testTextRight6 = new Paragraph();
            //testTextRight6.Add("[insert text/додати текст]");

            //Cell rightCell9 = new Cell().Add(testTextRight6.SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            //Paragraph tradeDate6 = new Paragraph();
            //tradeDate6.AddTabStops(generalInfoTabLeft);
            //tradeDate6.Add("Calculation Agent: / Агент з Розрахунків");

            //tradeDate6.SetMarginLeft(20);

            //Cell leftCell10 = new Cell().Add(tradeDate6.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph testTextRight6 = new Paragraph();
            //testTextRight6.Add("[insert text/додати текст]");

            //Cell rightCell9 = new Cell().Add(testTextRight6.SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);

            //Paragraph tradeDate6 = new Paragraph();
            //tradeDate6.AddTabStops(generalInfoTabLeft);
            //tradeDate6.Add("Calculation Agent: / Агент з Розрахунків");

            //tradeDate6.SetMarginLeft(20);

            //Cell leftCell10 = new Cell().Add(tradeDate6.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph testTextRight6 = new Paragraph();
            //testTextRight6.Add("[insert text/додати текст]");

            //Cell rightCell9 = new Cell().Add(testTextRight6.SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph tradeDate4 = new Paragraph();
            //tradeDate4.AddTabStops(generalInfoTabLeft);
            //tradeDate4.Add("[Amount and currency payable by Party A]/\r\n[Сума та валюта, що підлягають сплаті\r\nСтороною А:]");

            //tradeDate4.SetMarginLeft(20);

            //Cell leftCell8 = new Cell().Add(tradeDate4.Add(new Tab())).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            //Paragraph testTextRight4 = new Paragraph();
            //testTextRight4.Add("[insert text/додати текст]");

            //Cell rightCell7 = new Cell().Add(testTextRight4.SetMultipliedLeading(2.0f)).SetFont(font).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);


            table4.AddCell(leftCell4);
            table4.AddCell(emptyCell);
            table4.AddCell(leftCell5);
            table4.AddCell(rightCell4);
            table4.AddCell(leftCell6);
            table4.AddCell(rightCell5);
            table4.AddCell(leftCell7);
            table4.AddCell(rightCell6);
            table4.AddCell(leftCell8);
            table4.AddCell(rightCell7);
            table4.AddCell(leftCell9);
            table4.AddCell(rightCellFixed);
            table4.AddCell(otherTerms);
            table4.AddCell(emptyCell);
            table4.AddCell(leftCell10);
            table4.AddCell(rightCell9);
            table4.AddCell(leftCell11);
            table4.AddCell(rightCell10);
            table4.AddCell(leftCell12);
            table4.AddCell(rightCell11);
            table4.AddCell(leftCell13);
            table4.AddCell(rightCell12);
            table4.AddCell(leftCell14);
            table4.AddCell(rightCell13);
            table4.AddCell(leftCell15);
            table4.AddCell(rightCell14);


            document.Add(table4);

            document.Add(table5);
            //document.Add(paragraph2);
            //document.Add(paragraph3);
            //document.Add(paragraph);



            //// Part 2 - Introduction
            //document.Add(new Paragraph("\nThe purpose of this letter (the \"Confirmation\") is to confirm the terms and conditions of the Transaction entered into between us on the Trade Date specified below (the \"Transaction\"). This Confirmation constitutes a \"Confirmation\" as defined in the Master Agreement specified below.")
            //    .SetTextAlignment(TextAlignment.JUSTIFIED));
            //document.Add(new Paragraph("Цим листом (далі – \"Підтвердження\") підтверджуються умови Правочину, укладеного нами у Дату Правочину, зазначену нижче (далі – \"Правочин\"). Це Підтвердження становить \"Підтвердження\" як визначено в Генеральній Угоді, зазначеній нижче.")
            //    .SetTextAlignment(TextAlignment.JUSTIFIED));

            //// Part 3 - Definitions and Conditions
            //document.Add(new Paragraph("\nThe definitions and provisions contained in the Derivative Transactions Definitions are incorporated into this Confirmation. In the event of any inconsistency between those definitions and provisions and this Confirmation, this Confirmation will prevail.")
            //    .SetTextAlignment(TextAlignment.JUSTIFIED));
            //document.Add(new Paragraph("Визначення та умови, що містяться у Типових Умовах Деривативних Правочинів складають частину цього Підтвердження. У випадку будь-яких розбіжностей між умовами цього Підтвердження та Типовими Умовами, положення цього Підтвердження мають вищу юридичну силу.")
            //    .SetTextAlignment(TextAlignment.JUSTIFIED));

            //Close document
            document.Close();

            Console.WriteLine("PDF created successfully!");

        }
        //private static Cell NewParagraph(string text, TabStop? tabstop, TextAlignment? textAlignment, PdfFont? font, float leading, bool isEmpty)
        //{
        //    Cell cell = new Cell();
        //    Paragraph paragraph = new Paragraph();

        //    if (isEmpty)
        //    {
        //        if (tabstop != null)
        //        {
        //            paragraph.AddTabStops(tabstop);

        //           cell = cell.Add(paragraph.Add(new Tab())
        //                     .Add(text)
        //                     .SetMultipliedLeading(leading).SetFont(font).SetTextAlignment(textAlignment).SetBorder(Border.NO_BORDER);
        //        }

        //        cell = cell.Add(paragraph.Add(text)
        //                 .SetMultipliedLeading(leading).SetFont(font).SetTextAlignment(textAlignment).SetBorder(Border.NO_BORDER);
        //    }
        //    else
        //    {
        //        if (tabstop != null)
        //        {
        //            paragraph.AddTabStops(tabstop);

        //            paragraph.Add(new Tab())
        //                     .Add(text)
        //                     .Add(new Tab()).SetMultipliedLeading(leading).SetFont(font).SetTextAlignment(textAlignment).SetBorder(Border.NO_BORDER);
        //        }

        //        paragraph.Add(text)
        //                 .Add(new Tab()).SetMultipliedLeading(leading).SetFont(font).SetTextAlignment(textAlignment).SetBorder(Border.NO_BORDER); ;
        //    }
          

        //    return paragraph;
        //}




    }

}