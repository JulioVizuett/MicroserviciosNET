// <summary>
// <copyright file="ListaBaseDatos.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>
namespace Example.Catalogos.Resources
{
    using System;
    using System.Collections.Generic;
    using Example.Catalogos.Entities.Model;

    /// <summary>
    /// Class BaseDatos
    /// </summary>
    public static class ListaBaseDatos
    {
        public static List<CatalogosModel> ListaDatos = new List<CatalogosModel>()
        {
            new CatalogosModel { Id = 1, FirstName = "Alejandro", LastName = "Ojeda", Email = "alejandro.ojeda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 2, FirstName = "Jorge", LastName = "Morales", Email = "jorge.morales@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 3, FirstName = "Arturo", LastName = "Miranda", Email = "arturo.miranda@axity.com", Birthdate = DateTime.Now },
            new CatalogosModel { Id = 4, FirstName = "Benjamin", LastName = "Galindo", Email = "benjamin.galindo@axity.com", Birthdate = DateTime.Now },
        };
    }
}