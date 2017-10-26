using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Models
{
    //Classe PAI
    public abstract class Campainha
    {

        //Importanção de DLL para uso do BEEP
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);

        public abstract void Musica();

        //Nome Da Música Encapsulada
        protected abstract string NomeMusica();

        public void Soar()
        {
            Musica();
        }

    }

    //Classes Herdeiras(campainha1,campainha2,campainha3) fazendo Override no Método "Musica" com Inserção do BEEP 
    //    & 
    //Override no metodo Encapsulado "NomeMusica" que retorna o nome da musica 
    public class Campainha1: Campainha
    {

        protected override string NomeMusica()
        {
            return "Subindo";
        }
        public  override void Musica()
        {
            Beep(0, 200);
            Beep(300, 200);
            Beep(600, 200);
            Beep(900, 200);
            Beep(1200, 200);
            Beep(1500, 200);
        }        
    }

    public class Campainha2 : Campainha
    {
        protected override string NomeMusica()
        {
            return "Descendo";
        }

        public override void Musica()
        {            
            Beep(1500, 200);
            Beep(1200, 200);
            Beep(900, 200);
            Beep(600, 200);
            Beep(300, 200);
            Beep(0, 200);                       
        }
    }

    public class Campainha3 : Campainha
    {
        protected override string NomeMusica()
        {
            return "CrazyFrog";
        }

        public override void Musica()
        {
            Beep(700, 400);
            Beep(900, 400);
            Beep(700, 300);
            Beep(700, 300);
            Beep(900, 400);
            Beep(700, 400);
            Beep(600, 300);
            Beep(700, 300);
        }
    }
}
