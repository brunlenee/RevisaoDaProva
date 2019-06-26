using RevisaoDaProva1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoDaProva1.Controllers
{
    public class ProfissaoController : Controller
    {
        
        public ActionResult Index()
        {
            List<Profissao> listadeProfissao = new List<Profissao>();
            return View(listapopulado());
        }

        public List<Profissao> listapopulado()
        {
            Profissao p1 = new Profissao();
            Profissao p2 = new Profissao();
            Profissao p3 = new Profissao();

            p1.ProfissaoId = 1;
            p1.Descrisao = "advodago";

            p2.ProfissaoId = 2;
            p2.Descrisao = "programador";

            p3.ProfissaoId = 3;
            p3.Descrisao = "analista";

            List<Profissao> listaCheia = new List<Profissao>();

            listaCheia.Add(p1);
            listaCheia.Add(p2);
            listaCheia.Add(p3);


            return listaCheia;
        }




    }
}