using AutoMapper;
using DesafioMeiFacil.Application;
using DesafioMeiFacil.Application.Interface;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Services;
using DesafioMeiFacil.Infra.Data.Repositories;
using DesafioMeiFacil.WebApi.ViewModels;
using System.Web.Mvc;
using System.Web.Security;

namespace DesafioMeiFacil.WebApi.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUsuarioAppService _usuarioApp;

        public AccountController()
            : this(new UsuarioAppService(new UsuarioService(new UsuarioRepository())))
        {
        }

        public AccountController(IUsuarioAppService usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }

        // GET: Account
        public ActionResult Login(string returnURL)
        {
            ViewBag.ReturnUrl = returnURL;
            return View(new UsuarioViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UsuarioViewModel login, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var usuario = _usuarioApp.BuscarPeloEmail(login.Email);
                var vLogin = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

                if (vLogin != null)
                {
                    if (vLogin.Ativo)
                    {
                        if (Equals(vLogin.Senha, login.Senha))
                        {
                            FormsAuthentication.SetAuthCookie(vLogin.Email, false);
                            if (Url.IsLocalUrl(returnUrl)
                            && returnUrl.Length > 1
                            && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//")
                            && returnUrl.StartsWith("/\\"))
                            {
                                return Redirect(returnUrl);
                            }

                            Session["Nome"] = vLogin.Nome;
                            Session["Sobrenome"] = vLogin.Sobrenome;

                            return RedirectToAction("Index", "Home");
                        }

                        else
                        {
                            ModelState.AddModelError("", "Senha informada Inválida!!!");
                            return View(new UsuarioViewModel());
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Usuário sem acesso para usar o sistema!!!");
                        return View(new UsuarioViewModel());
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-mail informado inválido!!!");
                    return View(new UsuarioViewModel());
                }
            }
            return View(login);
        }
    }
}