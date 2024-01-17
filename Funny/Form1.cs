namespace Funny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);

            Point start = new(-1338, 233);
            Point end = new(-533, 1375);

            int step = 6;


            DoPos(-34, 867);
            down();
            up();

            for (int i = 0; i < end.X - start.X; i += step)
            {
                DoPos(start.X + i, start.Y);
                down();
                DoPos(start.X + i, end.Y);
                up();
            }
        }


        private void down()
        {
            MouseInputs.MouseButton(MouseEventFlags.MOUSEEVENT_LEFTDOWN);
        }

        private void up()
        {
            MouseInputs.MouseButton(MouseEventFlags.MOUSEEVENT_LEFTUP);
        }

        private void DoPos(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            Thread.Sleep(25);
        }
    }
}