using CraigListSP.Page;
using NUnit.Framework;

namespace CraigListSP.Test
{
    internal class NavegacaoTest : NavegacaoPage
    {
        [Test]
        public void Navegacao()
        {
            Imoveis();
            PaginaInicial();
            Empregos();
            PaginaInicial();
            Servicos();
            PaginaInicial();
            PesquisaApartamento();
            PaginaInicial();
            PesquisaWebDev();
            FecharTela();
        }

    }
}
