# Conceptual Projects

This directory contains projects that demonstrate specific programming concepts, design patterns, algorithms, or architectural approaches. These projects focus on illustrating how to implement particular ideas or solve specific problems.

## Purpose

Conceptual projects help developers:
- Understand abstract programming concepts through concrete examples
- See design patterns in action
- Learn different architectural approaches
- Explore algorithms and data structures
- Compare different implementation strategies

## Project Guidelines

Each conceptual project should:
- Focus on a single concept or pattern
- Provide multiple examples or variations
- Include clear explanations of the concept
- Show practical use cases
- Compare with alternative approaches (when relevant)
- Include performance considerations
- Be well-documented with diagrams where helpful

## Adding Projects

Projects are added as Git submodules. To add a new conceptual project:

```bash
git submodule add <repository-url> conceptual-projects/<project-name>
```

See [CONTRIBUTING.md](../CONTRIBUTING.md) for detailed guidelines.

## Current Projects

Projects will be added here as Git submodules. Each project will have its own repository with complete documentation and source code.

### Example Structure

```
conceptual-projects/
├── solid-principles/           # SOLID principles with examples
├── design-patterns/            # Gang of Four patterns
├── dependency-injection/       # DI concepts and implementations
├── event-driven-architecture/  # Event-driven design patterns
├── cqrs-pattern/              # Command Query Responsibility Segregation
├── repository-pattern/         # Repository and Unit of Work patterns
├── clean-architecture/         # Clean Architecture implementation
├── microservices-patterns/     # Microservice design patterns
├── data-structures/           # Common data structures in C#
└── algorithms/                # Algorithm implementations
```

## Categories

### Design Patterns
Classic Gang of Four patterns and modern architectural patterns:
- Creational: Singleton, Factory, Builder, Prototype
- Structural: Adapter, Decorator, Facade, Proxy
- Behavioral: Observer, Strategy, Command, State

### Architectural Patterns
Large-scale application architecture concepts:
- Layered Architecture
- Clean Architecture
- Hexagonal Architecture
- Event-Driven Architecture
- Microservices Patterns

### SOLID Principles
Object-oriented design principles with practical examples:
- Single Responsibility Principle
- Open/Closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle

### Data Structures & Algorithms
Common computer science fundamentals:
- Linked Lists, Trees, Graphs
- Sorting and Searching
- Dynamic Programming
- Algorithm Optimization

## How to Use

1. Clone the portfolio repository with submodules:
   ```bash
   git clone --recursive https://github.com/roughcutsoftware/portfolio.git
   ```

2. Navigate to a conceptual project:
   ```bash
   cd conceptual-projects/<project-name>
   ```

3. Read the project's README.md to understand the concept

4. Open the .sln file in Visual Studio

5. Review the code and documentation

6. Run the examples to see the concept in action

## Learning Approach

To get the most out of conceptual projects:

1. **Read First**: Start with the README and documentation
2. **Understand the Problem**: Learn what problem the concept solves
3. **Study the Code**: Read through the implementation
4. **Run Examples**: Execute the code and observe behavior
5. **Experiment**: Modify the code to test your understanding
6. **Apply**: Try implementing the concept in your own projects

## Contributing

Have a concept you'd like to demonstrate? See [CONTRIBUTING.md](../CONTRIBUTING.md) to learn how to contribute!

## Suggested Reading Order

For systematic learning, consider this order:
1. SOLID Principles
2. Basic Design Patterns (Factory, Strategy, Observer)
3. Dependency Injection
4. Repository Pattern
5. Advanced Design Patterns
6. Architectural Patterns
7. Data Structures & Algorithms
