using System;

namespace Console1{
    class Usuario{
        public string nome;
        public string login;
        public string senha;
        public int qtdLogin;
        public float peso;
        public bool ehSolteiro;
        public char abrvNomeMeio;

        public bool Logar(string _login, string _senha){
            if (_login == login){
                if (_senha == senha){
                    return true;
                }
            }

            return false;
        }
    }
}
