﻿namespace HowToTrainWebApi.Domain.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int RegistroId { get; set; }

        public Registro Registro { get; set; }
    }
}
