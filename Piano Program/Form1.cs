using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang; //소리 다중 출력을 위한 Irrklang에 정의된 형식을 가져올 때 지시문
using System.Runtime.InteropServices;

namespace Piano_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //keyDown 클릭 이벤트 MouseDown일때 이미지 변경 및 소리 출력, label에 글자 출력
        //keyUP일때 이미지 원래대로
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    pictureBox1.BackgroundImage = Properties.Resources.image3; //Z키다운 시 이미지 변경
                    ISoundEngine engine1 = new ISoundEngine(); //engine1 변수선언(Irrklang시작)
                    ISoundSource source1 = engine1.AddSoundSourceFromIOStream(Properties.Resources.DO, "wav"); //리소스에 있는 DO음 불러오기
                    ISound sound1 = engine1.Play2D(source1, false, false, true);
                    //source1에 들어있는 사운드를 2D로 출력(source1에 있는 DO음, 반복플레이 false, 시작 일시정지 false, 소리를 냄 true)
                    keyboardkey.Text = "Z"; //label에 글자 출력
                    pianokey.Text = "C3"; //label에 글자 출력
                    break;
                case Keys.X:
                    pictureBox2.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine2 = new ISoundEngine();
                    ISoundSource source2 = engine2.AddSoundSourceFromIOStream(Properties.Resources.RE, "wav");
                    ISound sound2 = engine2.Play2D(source2, false, false, true);
                    keyboardkey.Text = "X";
                    pianokey.Text = "D3";
                    break;
                case Keys.C:
                    pictureBox3.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine3 = new ISoundEngine();
                    ISoundSource source3 = engine3.AddSoundSourceFromIOStream(Properties.Resources.MI, "wav");
                    ISound sound3 = engine3.Play2D(source3, false, false, true);
                    keyboardkey.Text = "C";
                    pianokey.Text = "E3";
                    break;
                case Keys.V:
                    pictureBox4.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine4 = new ISoundEngine();
                    ISoundSource source4 = engine4.AddSoundSourceFromIOStream(Properties.Resources.FA, "wav");
                    ISound sound4 = engine4.Play2D(source4, false, false, true);
                    keyboardkey.Text = "V";
                    pianokey.Text = "F3";
                    break;
                case Keys.B:
                    pictureBox5.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine5 = new ISoundEngine();
                    ISoundSource source5 = engine5.AddSoundSourceFromIOStream(Properties.Resources.SOL, "wav");
                    ISound sound5 = engine5.Play2D(source5, false, false, true);
                    keyboardkey.Text = "B";
                    pianokey.Text = "G3";
                    break;
                case Keys.N:
                    pictureBox6.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine6 = new ISoundEngine();
                    ISoundSource source6 = engine6.AddSoundSourceFromIOStream(Properties.Resources.LA, "wav");
                    ISound sound6 = engine6.Play2D(source6, false, false, true);
                    keyboardkey.Text = "N";
                    pianokey.Text = "A3";
                    break;
                case Keys.M:
                    pictureBox7.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine7 = new ISoundEngine();
                    ISoundSource source7 = engine7.AddSoundSourceFromIOStream(Properties.Resources.SI, "wav");
                    ISound sound7 = engine7.Play2D(source7, false, false, true);
                    keyboardkey.Text = "M";
                    pianokey.Text = "B3";
                    break;
                case Keys.A:
                    pictureBox8.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine8 = new ISoundEngine();
                    ISoundSource source8 = engine8.AddSoundSourceFromIOStream(Properties.Resources.DO2, "wav");
                    ISound sound8 = engine8.Play2D(source8, false, false, true);
                    keyboardkey.Text = "A";
                    pianokey.Text = "C4";
                    break;
                case Keys.S:
                    pictureBox9.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine9 = new ISoundEngine();
                    ISoundSource source9 = engine9.AddSoundSourceFromIOStream(Properties.Resources.RE2, "wav");
                    ISound sound9 = engine9.Play2D(source9, false, false, true);
                    keyboardkey.Text = "S";
                    pianokey.Text = "D4";
                    break;
                case Keys.D:
                    pictureBox10.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine10 = new ISoundEngine();
                    ISoundSource source10 = engine10.AddSoundSourceFromIOStream(Properties.Resources.MI2, "wav");
                    ISound sound10 = engine10.Play2D(source10, false, false, true);
                    keyboardkey.Text = "D";
                    pianokey.Text = "E4";
                    break;
                case Keys.F:
                    pictureBox11.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine11 = new ISoundEngine();
                    ISoundSource source11 = engine11.AddSoundSourceFromIOStream(Properties.Resources.FA2, "wav");
                    ISound sound11 = engine11.Play2D(source11, false, false, true);
                    keyboardkey.Text = "F";
                    pianokey.Text = "F4";
                    break;
                case Keys.G:
                    pictureBox12.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine12 = new ISoundEngine();
                    ISoundSource source12 = engine12.AddSoundSourceFromIOStream(Properties.Resources.SOL2, "wav");
                    ISound sound12 = engine12.Play2D(source12, false, false, true);
                    keyboardkey.Text = "G";
                    pianokey.Text = "G4";
                    break;
                case Keys.H:
                    pictureBox13.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine13 = new ISoundEngine();
                    ISoundSource source13 = engine13.AddSoundSourceFromIOStream(Properties.Resources.LA2, "wav");
                    ISound sound13 = engine13.Play2D(source13, false, false, true);
                    keyboardkey.Text = "H";
                    pianokey.Text = "A4";
                    break;
                case Keys.J:
                    pictureBox14.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine14 = new ISoundEngine();
                    ISoundSource source14 = engine14.AddSoundSourceFromIOStream(Properties.Resources.SI2, "wav");
                    ISound sound14 = engine14.Play2D(source14, false, false, true);
                    keyboardkey.Text = "J";
                    pianokey.Text = "B4";
                    break;
                case Keys.K:
                    pictureBox15.BackgroundImage = Properties.Resources.image3;
                    ISoundEngine engine15 = new ISoundEngine();
                    ISoundSource source15 = engine15.AddSoundSourceFromIOStream(Properties.Resources.DO3, "wav");
                    ISound sound15 = engine15.Play2D(source15, false, false, true);
                    keyboardkey.Text = "K";
                    pianokey.Text = "C5";
                    break;
                case Keys.Q:
                    pictureBox16.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine16 = new ISoundEngine();
                    ISoundSource source16 = engine16.AddSoundSourceFromIOStream(Properties.Resources.DOs, "wav");
                    ISound sound16 = engine16.Play2D(source16, false, false, true);
                    keyboardkey.Text = "Q";
                    pianokey.Text = "C#3";
                    break;
                case Keys.W:
                    pictureBox17.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine17 = new ISoundEngine();
                    ISoundSource source17 = engine17.AddSoundSourceFromIOStream(Properties.Resources.REs, "wav");
                    ISound sound17 = engine17.Play2D(source17, false, false, true);
                    keyboardkey.Text = "W";
                    pianokey.Text = "D#3";
                    break;
                case Keys.E:
                    pictureBox18.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine18 = new ISoundEngine();
                    ISoundSource source18 = engine18.AddSoundSourceFromIOStream(Properties.Resources.FAs, "wav");
                    ISound sound18 = engine18.Play2D(source18, false, false, true);
                    keyboardkey.Text = "E";
                    pianokey.Text = "F#3";
                    break;
                case Keys.R:
                    pictureBox19.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine19 = new ISoundEngine();
                    ISoundSource source19 = engine19.AddSoundSourceFromIOStream(Properties.Resources.SOLs, "wav");
                    ISound sound19 = engine19.Play2D(source19, false, false, true);
                    keyboardkey.Text = "R";
                    pianokey.Text = "G#3";
                    break;
                case Keys.T:
                    pictureBox20.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine20 = new ISoundEngine();
                    ISoundSource source20 = engine20.AddSoundSourceFromIOStream(Properties.Resources.LAs, "wav");
                    ISound sound20 = engine20.Play2D(source20, false, false, true);
                    keyboardkey.Text = "T";
                    pianokey.Text = "A#3";
                    break;
                case Keys.Y:
                    pictureBox21.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine21 = new ISoundEngine();
                    ISoundSource source21 = engine21.AddSoundSourceFromIOStream(Properties.Resources.DOs2, "wav");
                    ISound sound21 = engine21.Play2D(source21, false, false, true);
                    keyboardkey.Text = "Y";
                    pianokey.Text = "C#4";
                    break;
                case Keys.U:
                    pictureBox22.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine22 = new ISoundEngine();
                    ISoundSource source22 = engine22.AddSoundSourceFromIOStream(Properties.Resources.REs2, "wav");
                    ISound sound22 = engine22.Play2D(source22, false, false, true);
                    keyboardkey.Text = "U";
                    pianokey.Text = "D#4";
                    break;
                case Keys.I:
                    pictureBox23.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine23 = new ISoundEngine();
                    ISoundSource source23 = engine23.AddSoundSourceFromIOStream(Properties.Resources.FAs2, "wav");
                    ISound sound23 = engine23.Play2D(source23, false, false, true);
                    keyboardkey.Text = "I";
                    pianokey.Text = "F#4";
                    break;
                case Keys.O:
                    pictureBox24.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine24 = new ISoundEngine();
                    ISoundSource source24 = engine24.AddSoundSourceFromIOStream(Properties.Resources.SOLs2, "wav");
                    ISound sound24 = engine24.Play2D(source24, false, false, true);
                    keyboardkey.Text = "O";
                    pianokey.Text = "G#4";
                    break;
                case Keys.P:
                    pictureBox25.BackgroundImage = Properties.Resources.image2;
                    ISoundEngine engine25 = new ISoundEngine();
                    ISoundSource source25 = engine25.AddSoundSourceFromIOStream(Properties.Resources.LAs2, "wav");
                    ISound sound25 = engine25.Play2D(source25, false, false, true);
                    keyboardkey.Text = "P";
                    pianokey.Text = "A#4";
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    pictureBox1.BackgroundImage = Properties.Resources.image1; // Z키업 시 이미지 원래대로
                    break;
                case Keys.X:
                    pictureBox2.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.C:
                    pictureBox3.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.V:
                    pictureBox4.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.B:
                    pictureBox5.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.N:
                    pictureBox6.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.M:
                    pictureBox7.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.A:
                    pictureBox8.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.S:
                    pictureBox9.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.D:
                    pictureBox10.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.F:
                    pictureBox11.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.G:
                    pictureBox12.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.H:
                    pictureBox13.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.J:
                    pictureBox14.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.K:
                    pictureBox15.BackgroundImage = Properties.Resources.image1;
                    break;
                case Keys.Q:
                    pictureBox16.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.W:
                    pictureBox17.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.E:
                    pictureBox18.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.R:
                    pictureBox19.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.T:
                    pictureBox20.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.Y:
                    pictureBox21.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.U:
                    pictureBox22.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.I:
                    pictureBox23.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.O:
                    pictureBox24.BackgroundImage = Properties.Resources.image4;
                    break;
                case Keys.P:
                    pictureBox25.BackgroundImage = Properties.Resources.image4;
                    break;
            }
        }

        //마우스 클릭 이벤트 MouseDown일때 이미지 변경 및 소리 출력, label에 글자 출력
        //마우스 클릭 이벤트 MouseUP일때 이미지 원래대로
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine1 = new ISoundEngine();
            ISoundSource source1 = engine1.AddSoundSourceFromIOStream(Properties.Resources.DO, "wav");
            ISound sound1 = engine1.Play2D(source1, false, false, true);
            keyboardkey.Text = "Z";
            pianokey.Text = "C3";
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine2 = new ISoundEngine();
            ISoundSource source2 = engine2.AddSoundSourceFromIOStream(Properties.Resources.RE, "wav");
            ISound sound2 = engine2.Play2D(source2, false, false, true);
            keyboardkey.Text = "X";
            pianokey.Text = "D3";
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine3 = new ISoundEngine();
            ISoundSource source3 = engine3.AddSoundSourceFromIOStream(Properties.Resources.MI, "wav");
            ISound sound3 = engine3.Play2D(source3, false, false, true);
            keyboardkey.Text = "C";
            pianokey.Text = "E3";
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine4 = new ISoundEngine();
            ISoundSource source4 = engine4.AddSoundSourceFromIOStream(Properties.Resources.FA, "wav");
            ISound sound4 = engine4.Play2D(source4, false, false, true);
            keyboardkey.Text = "V";
            pianokey.Text = "F3";
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine5 = new ISoundEngine();
            ISoundSource source5 = engine5.AddSoundSourceFromIOStream(Properties.Resources.SOL, "wav");
            ISound sound5 = engine5.Play2D(source5, false, false, true);
            keyboardkey.Text = "B";
            pianokey.Text = "G3";
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine6 = new ISoundEngine();
            ISoundSource source6 = engine6.AddSoundSourceFromIOStream(Properties.Resources.LA, "wav");
            ISound sound6 = engine6.Play2D(source6, false, false, true);
            keyboardkey.Text = "N";
            pianokey.Text = "A3";
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine7 = new ISoundEngine();
            ISoundSource source7 = engine7.AddSoundSourceFromIOStream(Properties.Resources.SI, "wav");
            ISound sound7 = engine7.Play2D(source7, false, false, true);
            keyboardkey.Text = "M";
            pianokey.Text = "B3";
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine8 = new ISoundEngine();
            ISoundSource source8 = engine8.AddSoundSourceFromIOStream(Properties.Resources.DO2, "wav");
            ISound sound8 = engine8.Play2D(source8, false, false, true);
            keyboardkey.Text = "A";
            pianokey.Text = "C4";
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine9 = new ISoundEngine();
            ISoundSource source9 = engine9.AddSoundSourceFromIOStream(Properties.Resources.RE2, "wav");
            ISound sound9 = engine9.Play2D(source9, false, false, true);
            keyboardkey.Text = "S";
            pianokey.Text = "D4";
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine10 = new ISoundEngine();
            ISoundSource source10 = engine10.AddSoundSourceFromIOStream(Properties.Resources.MI2, "wav");
            ISound sound10 = engine10.Play2D(source10, false, false, true);
            keyboardkey.Text = "D";
            pianokey.Text = "E4";
        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine11 = new ISoundEngine();
            ISoundSource source11 = engine11.AddSoundSourceFromIOStream(Properties.Resources.FA2, "wav");
            ISound sound11 = engine11.Play2D(source11, false, false, true);
            keyboardkey.Text = "F";
            pianokey.Text = "F4";
        }

        private void pictureBox11_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine12 = new ISoundEngine();
            ISoundSource source12 = engine12.AddSoundSourceFromIOStream(Properties.Resources.SOL2, "wav");
            ISound sound12 = engine12.Play2D(source12, false, false, true);
            keyboardkey.Text = "G";
            pianokey.Text = "G4";
        }

        private void pictureBox12_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine13 = new ISoundEngine();
            ISoundSource source13 = engine13.AddSoundSourceFromIOStream(Properties.Resources.LA2, "wav");
            ISound sound13 = engine13.Play2D(source13, false, false, true);
            keyboardkey.Text = "H";
            pianokey.Text = "A4";
        }

        private void pictureBox13_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine14 = new ISoundEngine();
            ISoundSource source14 = engine14.AddSoundSourceFromIOStream(Properties.Resources.SI2, "wav");
            ISound sound14 = engine14.Play2D(source14, false, false, true);
            keyboardkey.Text = "J";
            pianokey.Text = "B4";
        }

        private void pictureBox14_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.image3;
            ISoundEngine engine15 = new ISoundEngine();
            ISoundSource source15 = engine15.AddSoundSourceFromIOStream(Properties.Resources.DO3, "wav");
            ISound sound15 = engine15.Play2D(source15, false, false, true);
            keyboardkey.Text = "K";
            pianokey.Text = "C5";
        }

        private void pictureBox15_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox15.BackgroundImage = Properties.Resources.image1;
        }

        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine16 = new ISoundEngine();
            ISoundSource source16 = engine16.AddSoundSourceFromIOStream(Properties.Resources.DOs, "wav");
            ISound sound16 = engine16.Play2D(source16, false, false, true);
            keyboardkey.Text = "Q";
            pianokey.Text = "C#3";
        }

        private void pictureBox16_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox16.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox17.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine17 = new ISoundEngine();
            ISoundSource source17 = engine17.AddSoundSourceFromIOStream(Properties.Resources.REs, "wav");
            ISound sound17 = engine17.Play2D(source17, false, false, true);
            keyboardkey.Text = "W";
            pianokey.Text = "D#3";
        }

        private void pictureBox17_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox17.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox18.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine18 = new ISoundEngine();
            ISoundSource source18 = engine18.AddSoundSourceFromIOStream(Properties.Resources.FAs, "wav");
            ISound sound18 = engine18.Play2D(source18, false, false, true);
            keyboardkey.Text = "E";
            pianokey.Text = "F#3";
        }

        private void pictureBox18_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox18.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox19.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine19 = new ISoundEngine();
            ISoundSource source19 = engine19.AddSoundSourceFromIOStream(Properties.Resources.SOLs, "wav");
            ISound sound19 = engine19.Play2D(source19, false, false, true);
            keyboardkey.Text = "R";
            pianokey.Text = "G#3";
        }

        private void pictureBox19_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox19.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox20.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine20 = new ISoundEngine();
            ISoundSource source20 = engine20.AddSoundSourceFromIOStream(Properties.Resources.LAs, "wav");
            ISound sound20 = engine20.Play2D(source20, false, false, true);
            keyboardkey.Text = "T";
            pianokey.Text = "A#3";
        }

        private void pictureBox20_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox20.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox21.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine21 = new ISoundEngine();
            ISoundSource source21 = engine21.AddSoundSourceFromIOStream(Properties.Resources.DOs2, "wav");
            ISound sound21 = engine21.Play2D(source21, false, false, true);
            keyboardkey.Text = "Y";
            pianokey.Text = "C#4";
        }

        private void pictureBox21_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox21.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox22.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine22 = new ISoundEngine();
            ISoundSource source22 = engine22.AddSoundSourceFromIOStream(Properties.Resources.REs2, "wav");
            ISound sound22 = engine22.Play2D(source22, false, false, true);
            keyboardkey.Text = "U";
            pianokey.Text = "D#4";
        }

        private void pictureBox22_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox22.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox23.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine23 = new ISoundEngine();
            ISoundSource source23 = engine23.AddSoundSourceFromIOStream(Properties.Resources.FAs2, "wav");
            ISound sound23 = engine23.Play2D(source23, false, false, true);
            keyboardkey.Text = "I";
            pianokey.Text = "F#4";
        }

        private void pictureBox23_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox23.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox24.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine24 = new ISoundEngine();
            ISoundSource source24 = engine24.AddSoundSourceFromIOStream(Properties.Resources.SOLs2, "wav");
            ISound sound24 = engine24.Play2D(source24, false, false, true);
            keyboardkey.Text = "O";
            pianokey.Text = "G#4";
        }

        private void pictureBox24_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox24.BackgroundImage = Properties.Resources.image4;
        }

        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox25.BackgroundImage = Properties.Resources.image2;
            ISoundEngine engine25 = new ISoundEngine();
            ISoundSource source25 = engine25.AddSoundSourceFromIOStream(Properties.Resources.LAs2, "wav");
            ISound sound25 = engine25.Play2D(source25, false, false, true);
            keyboardkey.Text = "P";
            pianokey.Text = "A#4";
        }

        private void pictureBox25_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox25.BackgroundImage = Properties.Resources.image4;
        }

        //전원 버튼 닫기 및 마우스오버, 리브 시 이미지 변경
        private void ExitKey_Click(object sender, EventArgs e)
        {
            this.Close(); // 전원버튼으로 닫기
        }

        private void ExitKey_MouseHover(object sender, EventArgs e)
        {
            ExitKey.BackgroundImage = Properties.Resources.exit3;
        }

        private void ExitKey_MouseLeave(object sender, EventArgs e)
        {
            ExitKey.BackgroundImage = Properties.Resources.exit1;
        }
        // 창 최소화 및 마우스 오버 리브 시 이미지 변경
        private void minKey_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minKey_MouseHover(object sender, EventArgs e)
        {
            minKey.BackgroundImage = Properties.Resources.min2;
        }

        private void minKey_MouseLeave(object sender, EventArgs e)
        {
            minKey.BackgroundImage = Properties.Resources.min1;
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);//외부참조
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public readonly int WM_NLBUTTONDOWN = 0xA1;
        public readonly int HT_CAPTION = 0x2;

        private void moveKey_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 다른 컨트롤에 묶여있을 수 있을 수 있으므로 마우스캡쳐 해제
                ReleaseCapture();

                // 타이틀 바의 다운 이벤트처럼 보냄
                SendMessage(this.Handle, WM_NLBUTTONDOWN, HT_CAPTION, 0);
            }

            base.OnMouseDown(e);
        }

        private void moveKey_MouseLeave(object sender, EventArgs e)
        {
            moveKey.BackgroundImage = Properties.Resources.move1;
        }

        private void moveKey_MouseHover(object sender, EventArgs e)
        {
            moveKey.BackgroundImage = Properties.Resources.move2;
        }

    }
}

