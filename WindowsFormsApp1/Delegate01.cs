using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowsFormsApp1
{
    public delegate void Delegate_Contador(Contador instancia_contador);

    public class Contador
    {
        /// <summary>
        /// Propriedade que irá conter o método a ser invocado. que pertence a outro objeto, classe etc
        /// </summary>
        public Delegate_Contador Invocar_Delegate_Contador { get; set; }

        public void StarCount(int contarAte = 1000)
        {
            var cont = 1;
            while (cont <= contarAte)
            {
                Thread.Sleep(10);
                cont++;
            }

            //Aqui você vê se a propriedade foi instanciada por outro objeto. se sim ira invocar a ação
            if (Invocar_Delegate_Contador != null)
                //O this representa a instancia da classe, poderia ser qualquer objeto ou até mesmo colocar mais parametros
                Invocar_Delegate_Contador(this);
        }
    }
}
