using CraigListSP.Core;
using OpenQA.Selenium;

namespace CraigListSP.Page
{
    public class NavegacaoPage : Inicio
    {
        public void Imoveis()
        {
            Clique("//*[@id=\'hhh']/h3/a");           
        }
        public void PaginaInicial()
        {
            Clique("/html/body/div[1]/header/div[1]/a");

        }
        public void Empregos()
        {
            Clique("//*[@id=\'jjj\']/h3/a");

        }
        public void Servicos()
        {
            Clique("//*[@id=\'bbb\']/h3/a");
        }
        public void PesquisaApartamento()
        {
            Clique("//*[@id=\'leftbar\']/div[1]/div/input");
            Digite("//*[@id=\'leftbar\']/div[1]/div/input", "apartamento");
            Digite("//*[@id=\'leftbar\']/div[1]/div/input", Keys.Enter);
        }
        public void PesquisaWebDev()
        {
            Clique("//*[@id=\'leftbar\']/div[1]/div/input");
            Digite("//*[@id=\'leftbar\']/div[1]/div/input", "Web Developer");
            Digite("//*[@id=\'leftbar\']/div[1]/div/input", Keys.Enter);
        }

    }
}
