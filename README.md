# Introdução

O MongoDB é um banco de dados NoSQL baseado em documentos de uso geral, projetado para aplicações modernas e em nuvem.
Ele é escrito na linguagem de programação C++.
O MongoDB opera com o conceito de coleções e documentos.
Ele não possui conceitos como esquema, tabela, linha e SQL, pois é um banco de dados puramente orientado a documentos que trabalha com qualquer tamanho e tipo de dados.

### Recursos do MongoDB

* Plataforma Cruzada
* Banco de dados orientado a documentos
* Alta escalabilidade e desempenho
* Alta disponibilidade e durabilidade

Conceitos Básicos do MongoDB

**Banco de Dados** - No MongoDB, um banco de dados é um conjunto de coleções.
**Coleção** - No MongoDB, uma coleção é um grupo de documentos. É diferente de uma tabela em um banco de dados relacional; dentro da coleção, muitos documentos têm campos diferentes que não estão vinculados a nenhum esquema, como vemos em bancos de dados SQL.

**Documento** - No MongoDB, um documento é um conjunto de pares chave-valor, e ele possui uma estrutura dinâmica, o que significa que os dados armazenados dentro do documento não precisam necessariamente ter o mesmo campo e estrutura.

**Índices** - O MongoDB fornece vários índices para executar consultas de maneira eficiente, o que ajuda a acelerar as consultas ao buscar dados.

**Conjuntos de Réplicas** - No MongoDB, ao criar qualquer banco de dados, ele criará pelo menos duas cópias do banco de dados, proporcionando alta disponibilidade. O MongoDB possui um conjunto de réplicas que replica continuamente dados entre elas.

**Sharding** - No MongoDB, sharding é o método de distribuir dados em vários clusters, e ele usará sharding quando o conjunto de dados for grande e precisar fornecer alta taxa de transferência.


> [!NOTE]
> Projeto desenvolvido para fins de estudos.

![Resultado API](images/Swagger.png)


![MongoDB](images/MongoDB.png)
