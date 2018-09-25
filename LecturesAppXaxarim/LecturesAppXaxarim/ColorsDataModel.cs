using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;

namespace LecturesAppXaxarim
{
    public class ColorsDataModel
    {
        public string Lecture{ get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageSource { get; set; }

        public static IList<ColorsDataModel> All { get; set; }

        static ColorsDataModel()
        {
            All = new ObservableCollection<ColorsDataModel> {
                new ColorsDataModel {
                    Lecture = "Modern Agile e o Futuro do Desenvolvimento de Software",
                    Name = "Alexandre Freire Kawakami",
                    Description = "\"Ágil\" se tornou mainstream. Basta instalar o Jira e ter uma \"daily\" pra fazer Scrum... mas desencana das retrospectivas. Basta instalar o Jenkins que \"fazemos CI\", não importa que o código está parado numa PR num feature branch já fazem semanas. Basta instalar o Kubernets que temos DevOps, nem pensa em falar que os sysadmins deveriam codar e os devs responder à incidentes de produção. Nossa indústria novamente demonstra como é capaz de pegar qualquer inovação e co-optar em mais do mesmo. Venha ver como um retorno à princípios, inspirado na comunidade de Modern Agile, pode nos ajudar a achar o próximo passo, explorando agilidade de arquitetura e também de negócios enquanto experimentamos e aprendemos velozmente, entregamos valor continuamente, tornamos as pessoas sensacionais, sempre garantindo que a segurança seja um pré-requisito.",
                    ImageSource = "https://www.agileminas.com.br/2018/images/palestrantes/view-Alexandre.jpg"
                },
                new ColorsDataModel {
                    Lecture = "Squads - Mitos, Verdades e a Realidade nas Empresas Mineiras",
                    Name = "Marco Mendes",
                    Description = "Nessa sessão iremos discutir o estado atual da implementação de Squads em algumas empresas de Minas Gerais. Iremos apresentar alguns mitos sobre Squads, alguns princípios que orientam essa estrutura de trabalho e o aprendizado em algumas empresas de Minas Gerais. Iremos compartilhar aqui lições aprendidas e cuidados para gestores e líderes de equipe que estejam implementando esse modelo de trabalho.",
                    ImageSource = "https://www.agileminas.com.br/2018/images/palestrantes/view-Marco.jpg"
                },
                new ColorsDataModel {
                    Lecture = "Os desafios de desenvolver uma cultura ágil: eficiência, eficácia e economia",
                    Name = "Raphael Donaire Albino",
                    Description = "Nesta sessão compartilharei com a audiência ferramentas aplicadas em equipes que atuam em contextos ágeis e que foram úteis para a criação de ambientes eficientes (fazer a coisa da forma certa), eficazes (fazer o que é importante para o negócio) e econômicos (fazer de uma maneira barata).",
                    ImageSource = "https://www.agileminas.com.br/2018/images/palestrantes/view-Raphael.jpg"
                }
            };
        }
    }
}
