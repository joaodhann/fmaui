using fmaui.Properties;

namespace fmaui
{
    public partial class App : Application
    {
        List<Perguntas> pergunta_faceis = new()
        { 
            new Perguntas
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da Águaem forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }
            },
            new Perguntas
            {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }    




        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
