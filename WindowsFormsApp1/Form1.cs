using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch cronometro = new Stopwatch();


        private void btnContadorSemThread_Click(object sender, EventArgs e)
        {
            ChamarContador();
        }
                
        private void btnContadorComThread_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ChamarContador);
            thread.Start();
        }

        private void ChamarContador()
        {
            cronometro.Start();

            Action atualizeATelaSemErroDeThread = () =>
            {
                log.Clear();
                log.Text = string.Concat("Início: ", DateTime.Now, Environment.NewLine);
                Application.DoEvents();
            };
            Invoke(atualizeATelaSemErroDeThread);
            
            var contador = new Contador();

            //passar um método que será executado assim que um método da classe "Contador" invocar
            contador.Invocar_Delegate_Contador = new Delegate_Contador(ChamarMetodoQuandoAcabar);

            //iniciar a rotina na classe "Contador"
            contador.StarCount(Convert.ToInt32(numContador.Value));
        }

        private void ChamarMetodoQuandoAcabar(Contador contador)
        {
            Action atualizeATelaSemErroDeThread = () =>
            {
                log.Text += string.Concat("Um delegate me chamou");
                cronometro.Stop();
                log.Text += string.Concat("Acabei de contar: ", DateTime.Now, Environment.NewLine);
                log.Text += string.Concat("Levei: ", cronometro.Elapsed.TotalSeconds, " segundos");
                Application.DoEvents();
            };
            Invoke(atualizeATelaSemErroDeThread);
        }
    }
}
