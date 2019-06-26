using RevisaoDaProva1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoDaProva1.Controllers
{
    public class ProfissonalController : Controller
    {

        public ActionResult Index()
        {
            return View(listapopulado());
        }


        public List<Profissonal> listapopulado()
        {
            Profissonal p1 = new Profissonal();
            Profissonal p2 = new Profissonal();
            Profissonal p3 = new Profissonal();

            p1.ProfissonalId = 1;
            p1.Nome = "bruno";

            p2.ProfissonalId = 2;
            p2.Nome = "thiago";

            p3.ProfissonalId = 3;
            p3.Nome = "Juliano";

            List<Profissonal> listaCheia = new List<Profissonal>();

            listaCheia.Add(p1);
            listaCheia.Add(p2);
            listaCheia.Add(p3);


            return listaCheia;
        }

        public ActionResult Create()
        {
            ProfissaoController Criar = new ProfissaoController();

            ViewBag.profissaoId = new SelectList(Criar.listapopulado(), "ProfissaoId", "Descrisao");

            return View();
        }
    }
}