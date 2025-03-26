using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace stack_queue
{
    public partial class Form1 : Form
    {
        Stack<int> s = new Stack<int>();
        Queue q = new Queue();
        Thread t1;
        Thread t2;
        bool statoT1 = true;
        bool statoT2 = true;

        public Form1()
        {
            InitializeComponent();
            t1 = new Thread(ThreadStack);
            t2 = new Thread(ThreadQueue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statoT1 = false;
            foreach (var i in s)
            {
                stack.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThreadStack()
        {
            int i = 0;
            while (statoT1)
            {
                s.Push(i);
                i++;
                Thread.Sleep(1000);
            }
        }

        private void ThreadQueue()
        {
            int i = 0;
            while (statoT2)
            {
                q.Enqueue(i);
                i++;
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (statoT1)
            {
                t1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(statoT2)
            {
                t2.Start();
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statoT2 = false;
            foreach (var i in q)
            {
                queue.Items.Add(i);
            }
        }

        private void stack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
