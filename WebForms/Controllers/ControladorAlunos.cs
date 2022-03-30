using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Data;
using WebForms.Models;
using WindowsForms;

namespace WebForms
{

    public class ControladorAlunos : Controller
    {

        private RepositorioAluno repositorioAluno = new();
        // GET: ControladorAlunos
        public ActionResult Index (string searchString, int matricula)
        {
            var alunosFiltrados = from alunos in repositorioAluno.GetAll()
                                          select alunos;

            IEnumerable<AlunoModel> teste = alunosFiltrados.Select(m => new AlunoModel()
            {
                Nome = m.Nome,
                Matricula = m.Matricula
            });

            IEnumerable<Aluno> teste2 = teste.Select(m => new Aluno()
            {
                Nome = m.Nome,
                Matricula = m.Matricula
            });

            if (!String.IsNullOrEmpty(searchString))
            {
                alunosFiltrados = alunosFiltrados.Where(s => s.Nome.Contains(searchString, StringComparison.InvariantCultureIgnoreCase));
                return View(alunosFiltrados);
            }
            

            if (matricula != 0)
            {
                alunosFiltrados = alunosFiltrados.Where(s => s.Matricula == matricula);
                return View(alunosFiltrados);
            }

            return View(repositorioAluno.GetAll());
        }

        // GET: ControladorAlunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControladorAlunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IEnumerable <Aluno> alunos, Aluno aluno)
        {
            alunos = repositorioAluno.GetAll();
            if (!VerificacoesWebForms.VerificaCPF(aluno))
            {
                ModelState.AddModelError("", "O CPF digitado é inválido");
            }
            if (!VerificacoesWebForms.VerificaCPFsIguais(aluno, alunos))
            {
                ModelState.AddModelError("", "O CPF digitado já está cadastrado no sistema");
            }
            if (VerificacoesWebForms.VerificaIdade(aluno))
            {
                ModelState.AddModelError("", "O aluno deve ser nascido entre 1900 e 2020");
            }
            if (VerificacoesWebForms.VerificaMatricula(aluno))
            {
                ModelState.AddModelError("", "A Matrícula deve ser formada apenas por números e ter até 9 dígitos");
            }
            if (VerificacoesWebForms.VerificaMatriculaVazia(aluno))
            {
                ModelState.AddModelError("", "O campo matrícula é obrigatório");
            }
            if (VerificacoesWebForms.VerificaMatriculaIguais(aluno, alunos))
            {
                ModelState.AddModelError("", "A matrícula digitada já está cadastrada no sistema");
            }
            if (VerificacoesWebForms.VerificaNascimento(aluno))
            {
                ModelState.AddModelError("", "A data de nascimento digitada é inválida");
            }
            if (VerificacoesWebForms.VerificaNascimentoVazio(aluno))
            {
                ModelState.AddModelError("", "O campo nascimento é obrigatório");
            }
            if (VerificacoesWebForms.VerificaNome(aluno))
            {
                ModelState.AddModelError("", "O nome digitado deve conter apenas letras e ser formado por até 100 dígitos");
            }
            if (VerificacoesWebForms.VerificaNomeVazio(aluno))
            {
                ModelState.AddModelError("", "O campo nome é obrigatório");
            }

            if (ModelState.IsValid)
            {
                repositorioAluno.Add(aluno);
                ViewBag.Message = "Aluno cadastrado com sucesso";
                return RedirectToAction("Index");
            }
            else
            {
                return View(aluno);
            }
        }

        public ActionResult Edit(int matricula)
        {
            Aluno aluno = repositorioAluno.GetByMatricula(matricula);
            return View(aluno);
        }

        [HttpPost, ActionName ("Edit")]
        public ActionResult EditConfirmed(Aluno aluno, IEnumerable <Aluno> alunos)
        {
            alunos = repositorioAluno.GetAll();
            if (!VerificacoesWebForms.VerificaCPF(aluno))
            {
                ModelState.AddModelError("", "O CPF digitado é inválido");
            }
            if (!VerificacoesWebForms.VerificaCPFsIguais(aluno, alunos))
            {
                ModelState.AddModelError("", "O CPF digitado já está cadastrado no sistema");
            }
            if (VerificacoesWebForms.VerificaIdade(aluno))
            {
                ModelState.AddModelError("", "O aluno deve ser nascido entre 1900 e 2020");
            }
            if (VerificacoesWebForms.VerificaMatricula(aluno))
            {
                ModelState.AddModelError("", "A Matrícula deve ser formada apenas por números e ter até 9 dígitos");
            }
            if (VerificacoesWebForms.VerificaMatriculaVazia(aluno))
            {
                ModelState.AddModelError("", "O campo matrícula é obrigatório");
            }
            if (VerificacoesWebForms.VerificaNascimento(aluno))
            {
                ModelState.AddModelError("", "A data de nascimento digitada é inválida");
            }
            if (VerificacoesWebForms.VerificaNascimentoVazio(aluno))
            {
                ModelState.AddModelError("", "O campo nascimento é obrigatório");
            }
            if (VerificacoesWebForms.VerificaNome(aluno))
            {
                ModelState.AddModelError("", "O nome digitado deve conter apenas letras e ser formado por até 100 dígitos");
            }
            if (VerificacoesWebForms.VerificaNomeVazio(aluno))
            {
                ModelState.AddModelError("", "O campo nome é obrigatório");
            }
            
            if (ModelState.IsValid)
            {
                repositorioAluno.Update(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: ControladorAlunos/Delete/5
        // POST: Pessoa/Delete/5
        public ActionResult Delete(int matricula)
        {
            Aluno aluno = repositorioAluno.GetByMatricula(matricula);
            if (aluno == null)
            {
                ViewBag.Message = "Aluno não encontrado";
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int matricula)
        {
            Aluno aluno = repositorioAluno.GetByMatricula(matricula);
            repositorioAluno.Remove(aluno);
 
            return RedirectToAction("Index");
        }

    }
}
