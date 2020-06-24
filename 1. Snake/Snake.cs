using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Snake
    {
        Panel field;
        public Directions Direction { get; set; }
        public Directions CurrentDirection { get; set; }
        public List<Piece> snakesBody { get; set; }

        public Snake(Panel field)
        {
            this.field = field;
            startGame();
        }

        void startGame()
        {
            snakesBody = new List<Piece>();
            snakesBody.Add(new Piece(15, 15, 15, 15));
            Direction = Directions.Right;
        }

        public void AddNewPiece(int value)
        {
            for (int i=0; i<value; i++)
                snakesBody.Add(new Piece(snakesBody[snakesBody.Count - 1].X, snakesBody[snakesBody.Count - 1].Y, 15, 15));
        }

        public void Move()
        {
            Piece r;
            for (int i = snakesBody.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Direction)
                    {
                        case Directions.Right:
                            r = snakesBody[i];
                            r.X++;
                            if (r.X > field.Width / 15)
                                r.X = field.Location.X / 15;
                            snakesBody[i] = r;
                            break;
                        case Directions.Left:
                            r = snakesBody[i];
                            r.X--;
                            if (r.X < field.Location.X / 15)
                                r.X = field.Width / 15;
                            snakesBody[i] = r;
                            break;
                        case Directions.Up:
                            r = snakesBody[i];
                            r.Y--;
                            if (r.Y + 1.5 < field.Location.Y / 15)
                                r.Y = field.Height / 15;
                            snakesBody[i] = r;
                            break;
                        case Directions.Down:
                            r = snakesBody[i];
                            r.Y++;
                            if (r.Y > field.Height / 15)
                                r.Y = 0;
                            snakesBody[i] = r;
                            break;
                    }
                }
                else
                {
                    r = snakesBody[i - 1];
                    snakesBody[i] = r;
                }
            }
        }
        public void DrawSnake(Graphics g)
        {
            Brush snakeColor;
            for (int i = 0; i < snakesBody.Count; i++)
            {
                if (i == 0)
                    snakeColor = Brushes.Black;
                else
                    snakeColor = Brushes.ForestGreen;
                g.FillRectangle(snakeColor, snakesBody[i].X * 15, snakesBody[i].Y * 15, snakesBody[i].Width, snakesBody[i].Height);
            }
        }
        public bool CheckForGameOver()
        {
            Rectangle r1, r2;
            for (int i = 2; i < snakesBody.Count; i++)
            {
                r1 = new Rectangle(snakesBody[0].X * 15, snakesBody[0].Y * 15, snakesBody[i].Width, snakesBody[i].Height);
                r2 = new Rectangle(snakesBody[i].X * 15, snakesBody[i].Y * 15, snakesBody[i].Width, snakesBody[i].Height);
                if (r1.Contains(r2.CenterOfRectangle()) | r2.Contains(r1.CenterOfRectangle())
                    | r1.ExtremeEdges().ToList().All(e => r2.Contains(e))
                    | r2.ExtremeEdges().ToList().All(e => r1.Contains(e)))
                    return true;
            }
            return false;
        }
    }
}
