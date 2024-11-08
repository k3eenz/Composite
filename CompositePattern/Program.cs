using CompositePattern;
Document document = new Document();

Section section1 = new Section("Секция1");
Section section2 = new Section("Секция2");

section1.Add(new Paragraph("Первый параграф"));
section1.Add(new Paragraph("Второй"));

section2.Add(new Paragraph("Параграф во 2 секции"));
section1.Add(section2);

document.Add(section1);

document.Display();