﻿namespace AUA.SSO.DomainEntities.Entities.Clients
{
    public class ClientSecret : Secret
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }

}
