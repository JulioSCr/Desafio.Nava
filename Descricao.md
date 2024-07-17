1 - Imagine diversas listas de atividades. Essas listas devem ser identificadas por um nome, como Trabalho, Estudo, Lazer, etc.
2 - Cada lista possui uma série de Atividades.
3 - As Atividades dessa lista devem herdar de uma interface IAtividade e possuir atributos como Id, Nome, EstaConcluída.
4 - É necessário criar um serviço para gerenciar atividades. Este serviço deve ser implementado como um Singleton (com injeção de dependência - DI) para garantir que haja apenas uma instância compartilhada em toda a aplicação.
5 - Importante: Não é permitido criar instâncias da classe do serviço usando new(). Utilize técnicas para garantir que o serviço seja compartilhado como um Singleton e seja injetado corretamente onde necessário.
6 - Este serviço permite marcar que determinada atividade, de determinada lista, está concluída.
7 - Exiba corretamente as listas e suas respectivas atividades, se estão concluídas ou não.