using DesafioMeiFacil.Application.Interface;
using DesafioMeiFacil.Domain.ContractEntity.Usuario;
using System;
using System.Web.Security;

namespace DesafioMeiFacil.WebApi.LoginRoles
{
    public class Roles : RoleProvider
    {
        private readonly IUsuarioAppService _usuarioApp;

        public Roles() { }
        public Roles(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string sRoles = _usuarioApp.BuscarPeloEmail(username).Perfil.TryGetDescription();
            string[] retorno = { sRoles };
            return retorno;
        }
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}