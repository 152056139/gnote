using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


//使用
////set font Size font Style bold Italic
////
////普通  not bold italic 
////标题1  字体大小　24 Bold
////标题2  字体大小　18 Bold
////标题3  字体大小　14 Bold
////标题4  字体大小　12 Bold
////标题5  字体大小　10 Bold
////标题6  字体大小　8  Bold
////地址   字体大小　12 Italic

//private RichTextBoxCtrl.richTextBoxFontFormatClass r = new RichTextBoxCtrl.richTextBoxFontFormatClass();
//private void Form1_Load(object sender, EventArgs e)
//{
//    r.richTextBox = richTextBox1;
//    comboBox1.Items.Clear();
//    comboBox1.Items.AddRange(new object[] {
//             "普通",
//             "标题1",
//             "标题2",
//             "标题3",
//             "标题4",
//             "标题5",
//             "标题6",
//             "地址 "});
//}

//private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//{
//    r.SetFontFormat(comboBox1.SelectedIndex);

//    //SetFontFormat(comboBox1.SelectedIndex);
//    Text = r.GetFontFormat().ToString();
//}

//private void richTextBox1_SelectionChanged(object sender, EventArgs e)
//{
//    Text = r.GetFontFormat();
//    comboBox1.Text = r.GetFontFormat();
//}

namespace RichTextBoxCtrl
{
    class richTextBoxFontFormatClass
    {
        public richTextBoxFontFormatClass()
        {

        }
        public RichTextBox richTextBox;
      
        public void SetFontFormat(int formatIndex)
        {
            float fontSize = richTextBox.Font.Size;
            string fontName = richTextBox.Font.Name;
            switch (formatIndex)
            {
                case 0://普通
                    richTextBox.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
                    break;
                case 1://标题1 
                    richTextBox.SelectionFont = new Font(fontName, 24f, FontStyle.Bold);
                    break;
                case 2: //标题2
                    richTextBox.SelectionFont = new Font(fontName, 18f, FontStyle.Bold);
                    break;
                case 3: //标题3
                    richTextBox.SelectionFont = new Font(fontName, 14f, FontStyle.Bold);
                    break;
                case 4://标题4
                    richTextBox.SelectionFont = new Font(fontName, 12f, FontStyle.Bold);
                    break;
                case 5: //标题5
                    richTextBox.SelectionFont = new Font(fontName, 10f, FontStyle.Bold);
                    break;
                case 6: //标题6
                    richTextBox.SelectionFont = new Font(fontName, 8f, FontStyle.Bold);
                    break;
                case 7: //地址
                    richTextBox.SelectionFont = new Font(fontName, 12f, FontStyle.Italic);
                    break;
            }
        }
        public string GetFontFormat()
        {
            string Result = "普通";
            if (richTextBox.SelectionFont !=null )
            {           
                float fontSize = richTextBox.SelectionFont.Size;
                FontStyle fontStyle = richTextBox.SelectionFont.Style;

                if (fontSize == 24 && fontStyle == FontStyle.Bold)
                    Result = "标题1";
                else
                if (fontSize == 18 && fontStyle == FontStyle.Bold)
                    Result = "标题2";
                else
                if (fontSize == 14 && fontStyle == FontStyle.Bold)
                    Result = "标题3";
                else
                if (fontSize == 12 && fontStyle == FontStyle.Bold)
                    Result = "标题4";
                else
                if (fontSize == 10 && fontStyle == FontStyle.Bold)
                    Result = "标题5";
                else
                if (fontSize == 8 && fontStyle == FontStyle.Bold)
                    Result = "标题6";
                else
                if (fontSize == 12 && fontStyle == FontStyle.Italic)
                    Result = "地址";
                else
                    Result = "普通";
            }
            else
                Result = "普通";
            return Result;
        }
    }
}
