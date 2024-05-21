# Design Patterns em C#
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

- [Chain of Responsibility (CoR, Chain of Command)](StructuralPatterns/BehavioralPatterns)
Permite que uma solicitação seja passada por uma cadeia de manipuladores. Cada manipulador na cadeia decide se processa a solicitação ou a passa para o próximo manipulador.