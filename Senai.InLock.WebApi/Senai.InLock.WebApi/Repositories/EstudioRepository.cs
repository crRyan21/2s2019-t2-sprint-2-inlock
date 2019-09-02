using Microsoft.EntityFrameworkCore;
using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class EstudioRepository
    {
       
        public List<Estudios> Listar()
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                return ctx.Estudios.ToList();
            }
        }

        public void Cadastrar(Estudios estudio)
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                ctx.Estudios.Add(estudio);
                ctx.SaveChanges();
            }
        }
        public void Atualizar(Estudios estudio)
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                Estudios estudioBuscado = ctx.Estudios.Find(estudio.EstudioId);
                estudioBuscado.NomeEstudio = estudio.NomeEstudio;
                estudioBuscado.PaisOrigem = estudio.PaisOrigem;
                estudioBuscado.DataCriacao = Convert.ToDateTime(estudio.PaisOrigem);
                estudioBuscado.UsuarioId = Convert.ToInt32(estudio.UsuarioId);
                ctx.Estudios.Update(estudioBuscado);
                ctx.SaveChanges();
            }
        }
        public void Deletar(int id)
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                ctx.Estudios.Remove(ctx.Estudios.Find(id));
                ctx.SaveChanges();
            }
        }

        public Estudios BuscarPorId(int id)
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                return ctx.Estudios.Find(id);
            }
        }
        public Estudios ListarFuncionariosDoCargoPorNome(string nome)
        {
            using (InLock_Context ctx = new InLock_Context())
            {
                return ctx.Estudios.Include(x => x.NomeEstudio).FirstOrDefault(x => x.NomeEstudio == nome);
            }
        }
    }
}
