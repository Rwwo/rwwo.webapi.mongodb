# Introdu��o

O MongoDB � um banco de dados NoSQL baseado em documentos de uso geral, projetado para aplica��es modernas e em nuvem.
Ele � escrito na linguagem de programa��o C++.
O MongoDB opera com o conceito de cole��es e documentos.
Ele n�o possui conceitos como esquema, tabela, linha e SQL, pois � um banco de dados puramente orientado a documentos que trabalha com qualquer tamanho e tipo de dados.

### Recursos do MongoDB

* Plataforma Cruzada
* Banco de dados orientado a documentos
* Alta escalabilidade e desempenho
* Alta disponibilidade e durabilidade

Conceitos B�sicos do MongoDB

**Banco de Dados** - No MongoDB, um banco de dados � um conjunto de cole��es.
**Cole��o** - No MongoDB, uma cole��o � um grupo de documentos. � diferente de uma tabela em um banco de dados relacional; dentro da cole��o, muitos documentos t�m campos diferentes que n�o est�o vinculados a nenhum esquema, como vemos em bancos de dados SQL.

**Documento** - No MongoDB, um documento � um conjunto de pares chave-valor, e ele possui uma estrutura din�mica, o que significa que os dados armazenados dentro do documento n�o precisam necessariamente ter o mesmo campo e estrutura.

**�ndices** - O MongoDB fornece v�rios �ndices para executar consultas de maneira eficiente, o que ajuda a acelerar as consultas ao buscar dados.

**Conjuntos de R�plicas** - No MongoDB, ao criar qualquer banco de dados, ele criar� pelo menos duas c�pias do banco de dados, proporcionando alta disponibilidade. O MongoDB possui um conjunto de r�plicas que replica continuamente dados entre elas.

**Sharding** - No MongoDB, sharding � o m�todo de distribuir dados em v�rios clusters, e ele usar� sharding quando o conjunto de dados for grande e precisar fornecer alta taxa de transfer�ncia.


> [!NOTE]
> Projeto desenvolvido para fins de estudos.

![Resultado API](images/Swagger.png)


![MongoDB](images/MongoDB.png)
