namespace Console1{
    internal class Program{
        static void Main(string[] args){
            //Dado padrão que poderia vir de um banco de dados
            Usuario usuario = new Usuario();

            usuario.nome = "Gabriel";
            usuario.login = "root";
            usuario.senha = "qwe123";
            //------
            string login;
            string senha;
            do{
                Console.WriteLine("Digite seu login: ");
                login = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();

                Console.WriteLine("Digite novamente");
            } while(!usuario.Logar(login, senha));
        }
    }
}
