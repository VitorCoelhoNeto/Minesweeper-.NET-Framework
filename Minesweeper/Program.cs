using G41.Minesweeper.Common;
using G41.Minesweeper.Common.Models;
using Minesweeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    
    static class Program
    {
        public static string ID { get; set; }
        public static string User { get; set; }
        public static bool firstClick { get; set; }

        //Models
        public static Celula _ModelCelula { get; set; }
        public static Tabuleiro _ModelTabuleiro { get; set; }
        public static Server _ModelServer { get; set; }
        public static Jogador _ModelJogador { get; set; }

        //Views
        public static Tab _ViewInicio { get; set; }
        public static Facil _ViewFacil { get; set; }
        public static Intermedio _ViewIntermedio { get; set; }
        public static Leaderboards _ViewLeaderboards { get; set; }
        public static Ajuda _ViewAjuda { get; set; }
        public static Registo _ViewRegisto { get; set; }
        public static CriarConta _ViewCriarConta { get; set; }
        public static VerPerfis _ViewVerPerfis { get; set; }
        
        //Controllers
        public static Controller _ControllerMines { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //M
            //_ModelCelula = new Celula();
            //_ModelTabuleiro = new Tabuleiro();
            //_ModelJogador = new Jogador();
            _ModelServer = new Server();
            
            //V
            _ViewInicio = new Tab();
            _ViewFacil = new Facil();
            _ViewIntermedio = new Intermedio();
            _ViewLeaderboards = new Leaderboards();
            _ViewAjuda = new Ajuda();
            _ViewRegisto = new Registo();
            _ViewCriarConta = new CriarConta();
            _ViewVerPerfis = new VerPerfis();

            //C
            _ControllerMines = new Controller();

            Application.Run(/*new Tab()*/ _ViewInicio);
        }
    }
}
