# Design Patterns in C#
Este repositório é uma coleção abrangente e prática de padrões de design implementados em C#. Ele serve como um recurso valioso para desenvolvedores que desejam aprimorar suas habilidades em arquitetura de software, oferecendo exemplos detalhados e bem comentados de cada padrão de design.

## Creational Patterns 📦⚙️
Os padrões de criação (Creational Patterns) são técnicas de design em programação orientada a objetos que lidam com mecanismos de criação de objetos, buscando flexibilizar e otimizar a instânciação de classes.

- [FactoryMethod](CreationalPatterns/FactoryMethod)
Define uma interface para criar objetos, mas permite que as subclasses decidam qual classe instanciar.

- [AbstractFactory](CreationalPatterns/AbstractFactory)
Fornece uma interface para criar famílias de objetos relacionados sem especificar suas classes concretas.

- [Builder](CreationalPatterns/Builder)
Permite a construção de um objeto complexo passo a passo e oferece a possibilidade de construir variantes do objeto utilizando o mesmo código de construção.

- [Prototype](CreationalPatterns/Prototype)
Cria novos objetos a partir de protótipos existentes, clonando-os e permitindo a criação de novas instâncias sem depender de classes concretas.

- [Singleton](CreationalPatterns/Singleton)
Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a essa instância.

## Structural Patterns 🧱🔗
Os padrões estruturais (Structural Patterns) são técnicas de design que simplificam o design ao identificar maneiras simples de realizar relacionamentos entre entidades, facilitando a composição de interfaces ou a implementação de novas funcionalidades aos sistemas.

- [Adapter](StructuralPatterns/Adapter)
Permite que interfaces incompatíveis colaborem ao envolver uma das interfaces para que ela se adapte à outra.

- [Bridge](StructuralPatterns/Bridge)
Desacopla uma abstração da sua implementação, permitindo que as duas variem independentemente.