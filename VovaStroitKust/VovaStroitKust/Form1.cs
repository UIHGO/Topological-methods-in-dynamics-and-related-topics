using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VovaStroitKust
{
    public partial class Form1 : Form
    {
        int[,] map;
        int[] carier;
        int size, iter;
        bool finished, first;
        List<TreeElement> tree = new List<TreeElement>();
        
        public Form1()
        {
            InitializeComponent();

            size = 21;
            iter = 10;

            meshSizeText.Text = "" + size;
            IterationsCountText.Text = "" + iter;
        }

        public string getItem(int i)
        {
            switch (i)
            {
                case -1:
                    return ">";
                case -2:
                    return ">";
                default:
                    return "=";
            }
        }

        public void draw()
        {
            string text = "";
            for (int i = size - 1; i >= 0; i--)
            {
                for (int j = 0; j < size; j++)
                {
                    text += ("" + getItem(map[i, j]) + "  ");
                }
                text += "\n";
            }
            treeMap.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finished = false;
            tree.Clear();

            map = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    map[i, j] = i +1;
                }
            }
            addElementToTree(0, ((size - 1) / 2) + 1);
            carier = new int[2] { 0, ((size - 1) / 2) + 1 };
            draw();
        }

        private void addElementToTree(int x, int y)
        {
            tree.Add(new TreeElement(x, y));
            if (x > size - 1 || y > size - 1 || x < 0 || y < 0) { finished = true; }
            else
            {
                if (x > size - 2 || y > size - 2) { map[x, y] = -1; }
                else if (map[x, y + 1] == -1 || map[x, y - 1] == -1) { map[x, y] = -2; }
                else { map[x, y] = -1; }
            }
        }

        private void meshSizeText_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if(Int32.TryParse(meshSizeText.Text, out i))
            {
                size = i;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void treeMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void startGrowing_Click(object sender, EventArgs e)
        {
            int counter = 0;
            first = true;

            for (int i = 0; i < iter; i++)
            {
                int valForThisTurn = 2;
                
                for (int j = 0; j <= tree.Count - 1; j++)
                {
                    if (map[tree[j].pos[0] + 1, tree[j].pos[1]] > 0)
                    {
                        valForThisTurn += map[tree[j].pos[0] + 1, tree[j].pos[1]] - 1;
                    }
                }
                valForThisTurn = valForThisTurn - tree.Count + 1;
                label4.Text = valForThisTurn + "";

                //label3.Text = "" + map[tree[0].pos[0] + 1, tree[0].pos[1]];

                if (valForThisTurn > 0 || finished)
                {
                    
                    int[] move = new int[2];
                    switch (commandText.Text[counter])
                    {
                        case 'u':
                            move[0] = 1;
                            move[1] = 0;
                            break;
                        case 'l':
                            move[0] = 0;
                            move[1] = -1;
                            break;
                        case 'r':
                            move[0] = 0;
                            move[1] = 1;
                            break;
                        case 'd':
                            move[0] = -1;
                            move[1] = 0;
                            break;
                        default:
                            move[0] = 0;
                            move[1] = 0;
                            break;
                    }
                    for (int j = 0; j < valForThisTurn; j++)
                    {
                        if (carier[0] + move[0] > size - 2 || carier[1] + move[1] > size - 2 || carier[0] + move[0] < 1 || carier[1] + move[1] < 1) { finished = true; break; }
                        else
                        {
                            if (map[carier[0] + move[0], carier[1] + move[1]] > 0)
                            {
                                carier[0] += move[0];
                                carier[1] += move[1];
                                addElementToTree(carier[0], carier[1]);
                            }
                            else
                            {
                                while (map[carier[0] + move[0], carier[1] + move[1]] < 0)
                                {
                                    carier[0] += move[0];
                                    carier[1] += move[1];
                                }
                                valForThisTurn += 1;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }


                

                counter++;
                if (counter > commandText.Text.Length-1) counter = 0;
            }
            draw();

            for (int x = 0; x < treeMap.Text.Length; x++)
            {
                if (treeMap.Text[x] == '>')
                {
                    treeMap.Select(x, 1);
                    treeMap.SelectionColor = Color.Red;
                }
            }
            treeMap.Visible = true;
        }
        

        private void IterationsCountText_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (Int32.TryParse(IterationsCountText.Text, out i))
            {
                iter = i;
            }
        }
    }
}
