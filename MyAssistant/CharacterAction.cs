using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyAssistant
{
    public class CharacterAction
    {
        public CharacterAction(PictureBox pictureBox, Form_Main mainForm)
        {
            m_pictureBox = pictureBox;
            m_mainForm = mainForm;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        PictureBox m_pictureBox = null;
        Form_Main m_mainForm = null;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public int SetAction(string actionName)
        {
            Image imgChar = FindPicture(actionName);

            if (imgChar != null)
            {
                if (m_pictureBox.Image != null)
                {
                    m_pictureBox.Image.Dispose();
                }


                m_pictureBox.Image = imgChar;
                m_mainForm.Size = this.m_pictureBox.Image.Size;
            }


            return 0;
        }


        public bool CheckPictureExists(string name)
        {
            string customPath = "Img/Custom/" + name;
            string basicPath = "Img/Basic/" + name;


            return (File.Exists(customPath + ".gif") || File.Exists(customPath + ".png") || File.Exists(customPath + ".jpg") || File.Exists(customPath + ".bmp"))
                || (File.Exists(basicPath + ".gif") || File.Exists(basicPath + ".png") || File.Exists(basicPath + ".jpg") || File.Exists(basicPath + ".bmp"));
        }


        private Image FindPicture(string name)
        {
            string customPath = "Img/Custom/" + name;
            string basicPath = "Img/Basic/" + name;

            Image imgChar;


            try
            {
                imgChar = Image.FromFile(customPath + ".gif");
                return imgChar;
            }
            catch (System.IO.FileNotFoundException NoFileEcp)
            {
                try
                {
                    imgChar = Image.FromFile(customPath + ".png");
                    return imgChar;
                }
                catch (System.IO.FileNotFoundException NoFileEcp2)
                {
                    try
                    {
                        imgChar = Image.FromFile(customPath + ".jpg");
                        return imgChar;
                    }
                    catch (System.IO.FileNotFoundException NoFileEcp3)
                    {
                        try
                        {
                            imgChar = Image.FromFile(customPath + ".bmp");
                            return imgChar;
                        }
                        catch (System.IO.FileNotFoundException NoFileEcp4)
                        {

                        }
                    }
                }
            }


            try
            {
                imgChar = Image.FromFile(basicPath + ".gif");
                return imgChar;
            }
            catch (System.IO.FileNotFoundException NoFileEcp)
            {
                try
                {
                    imgChar = Image.FromFile(basicPath + ".png");
                    return imgChar;
                }
                catch (System.IO.FileNotFoundException NoFileEcp2)
                {
                    try
                    {
                        imgChar = Image.FromFile(basicPath + ".jpg");
                        return imgChar;
                    }
                    catch (System.IO.FileNotFoundException NoFileEcp3)
                    {
                        try
                        {
                            imgChar = Image.FromFile(basicPath + ".bmp");
                            return imgChar;
                        }
                        catch (System.IO.FileNotFoundException NoFileEcp4)
                        {

                        }
                    }
                }
            }


            return null;
        }
    }
}
