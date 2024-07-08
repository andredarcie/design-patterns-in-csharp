# Design Patterns em C# [PT-BR]

Este repositório é uma coleção abrangente e prática de padrões de design implementados em C#. Ele serve como um recurso valioso para desenvolvedores que desejam aprimorar suas habilidades em arquitetura de software, oferecendo exemplos detalhados e bem comentados de cada padrão de design.

## Creational Patterns 📦⚙️
Os padrões de criação (Creational Patterns) são técnicas de design em programação orientada a objetos que lidam com mecanismos de criação de objetos, buscando flexibilizar e otimizar a instânciação de classes.

- [FactoryMethod (Virtual Constructor)](CreationalPatterns/FactoryMethod)
Define uma interface para criar objetos, mas permite que as subclasses decidam qual classe instanciar.

- [AbstractFactory](CreationalPatterns/AbstractFactory)
Fornece uma interface para criar famílias de objetos relacionados sem especificar suas classes concretas.

- [Builder](CreationalPatterns/Builder)
Permite a construção de um objeto complexo passo a passo e oferece a possibilidade de construir variantes do objeto utilizando o mesmo código de construção.

- [Prototype (Clone)](CreationalPatterns/Prototype)
Cria novos objetos a partir de protótipos existentes, clonando-os e permitindo a criação de novas instâncias sem depender de classes concretas.

- [Singleton](CreationalPatterns/Singleton)
Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a essa instância.

## Structural Patterns 🧱🔗
Os padrões estruturais (Structural Patterns) são técnicas de design que simplificam o design ao identificar maneiras simples de realizar relacionamentos entre entidades, facilitando a composição de interfaces ou a implementação de novas funcionalidades aos sistemas.

- [Adapter (Wrapper)](StructuralPatterns/Adapter)
Permite que interfaces incompatíveis colaborem ao envolver uma das interfaces para que ela se adapte à outra.

- [Bridge](StructuralPatterns/Bridge)
Desacopla uma abstração da sua implementação, permitindo que as duas variem independentemente.

- [Composite (Object Tree)](StructuralPatterns/Composite)
Permite tratar objetos individuais e composições de objetos de maneira uniforme, organizando-os em uma estrutura de árvore.

- [Decorator (Wrapper)](StructuralPatterns/Decorator)
Permite estender a funcionalidade de um objeto dinamicamente, envolvendo-o em classes decoradoras que adicionam comportamentos ou estados adicionais sem modificar a classe original.

- [Facade](StructuralPatterns/Facade)
Fornece uma interface simplificada para um conjunto complexo de classes, subsistemas ou APIs, facilitando sua utilização pelos clientes sem expor detalhes de implementação complexos.

- [Flyweight (Cache)](StructuralPatterns/Flyweight)
Utilizado para minimizar o uso de memória ao compartilhar o máximo possível de dados entre objetos semelhantes. Isso é especialmente útil em situações onde um grande número de objetos são necessários, mas a maioria dos dados desses objetos podem ser compartilhados.
 
- [Proxy](StructuralPatterns/Proxy)
Atua como um intermediário para controlar o acesso a um objeto. Ele fornece uma substituição para o objeto real, permitindo que você adicione lógica adicional antes ou depois de acessar o objeto real, como verificação de permissões, cache, logging ou adiamento da criação e inicialização do objeto real até que ele seja necessário.

## Behavioral Patterns 🧠🔄
Os padrões comportamentais (Behavioral Patterns) são técnicas de design que simplificam a comunicação entre objetos e a delegação de responsabilidades, promovendo interações flexíveis e eficientes. Esses padrões ajudam a definir como os objetos interagem e colaboram, facilitando a implementação de fluxos de trabalho complexos.

- [Chain of Responsibility (CoR, Chain of Command)](BehavioralPatterns/ChainOfResponsibility)
Permite que uma solicitação seja passada por uma cadeia de manipuladores. Cada manipulador na cadeia decide se processa a solicitação ou a passa para o próximo manipulador.

- [Command (Action, Transaction)](BehavioralPatterns/Command)
Permite que solicitações sejam encapsuladas como objetos, permitindo que clientes parametrizem objetos com diferentes solicitações, filas ou registros de solicitações, e forneçam suporte para operações reversíveis.

- [Iterator](BehavioralPatterns/Iterator)
Fornece uma maneira de acessar os elementos de um agregado sequencialmente sem expor sua representação subjacente. Esse padrão permite a travessia de uma coleção de maneiras diferentes, encapsulando a lógica de travessia.

- [Mediator (Intermediary, Controller)](BehavioralPatterns/Mediator)
Define um objeto que encapsula como um conjunto de objetos interage. Este padrão promove o desacoplamento ao impedir que os objetos se refiram uns aos outros explicitamente, permitindo que suas interações variem independentemente.

- [Memento (Snapshot)](BehavioralPatterns/Memento)
É utilizado no design de software para permitir a captura e o armazenamento do estado atual de um objeto, de modo que possa ser restaurado para esse estado específico mais tarde.

- [Observer (Event-Subscriber, Listener)](BehavioralPatterns/Observer) 
O Observer Pattern é um padrão de design comportamental que define uma dependência um-para-muitos entre objetos, de forma que quando um objeto muda de estado, todos os seus dependentes são notificados e atualizados automaticamente.

- [State](BehavioralPatterns/State)
O State Pattern é um padrão de design comportamental que permite a um objeto alterar seu comportamento quando seu estado interno muda, parecendo assim que o objeto mudou sua classe.

- [Strategy](BehavioralPatterns/Strategy)
Permite definir uma família de algoritmos, encapsulá-los em classes separadas e torná-los intercambiáveis. Ele facilita a variação do algoritmo em tempo de execução, promovendo flexibilidade e manutenção do código ao seguir o princípio aberto/fechado.

- [Template Method](BehavioralPatterns/TemplateMethod)
Define a estrutura de um algoritmo em um método, deixando alguns passos para serem implementados pelas subclasses. Ele permite que subclasses redefinam certos passos de um algoritmo sem alterar sua estrutura geral. Isso promove o reuso de código, pois a lógica comum é mantida na classe base enquanto os detalhes específicos são delegados às subclasses.

- [Visitor](BehavioralPatterns/Visitor)
Permite que você adicione novas operações a objetos de uma estrutura sem modificar as classes desses objetos. Ele separa o algoritmo da estrutura dos objetos, permitindo que você defina novas operações em classes de visitantes (visitors) que são aplicadas aos objetos. Isso é útil quando você precisa executar operações variadas e complexas em uma coleção de objetos diferentes.