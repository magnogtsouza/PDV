using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
//using PDVNet.Dados.Nucleo;
//using PDVNet.Dados.PDV.Modelo.ModelosGerais;
//using PDVNet.Util;
//using PDVNet.Util.TelaProcura;

namespace PDVNet.Dados.PDV.Modelo;

public class ModeloPDV : DbContext
{
    //private static ModeloPDV _modelo;
    //static ModeloPDV()
    //{
    //    return _modelo;
    //    //DbInterception.Add(new EntityCommandInterceptor());
    //}


    public ModeloPDV() : base("name=ModeloPDV")
    {
        base.Configuration.AutoDetectChangesEnabled = false;
        base.Configuration.LazyLoadingEnabled = false;
    }
    public virtual DbSet<AUTORES> AUTORES { get; set; }

    public virtual DbSet<BANCOS> BANCOS { get; set; }

    public virtual DbSet<BATIMENTOS> BATIMENTOS { get; set; }

    public virtual DbSet<BONUS> BONUS { get; set; }

    public virtual DbSet<BONUSBOLETA> BONUSBOLETA { get; set; }

    public virtual DbSet<BORDERO> BORDERO { get; set; }

    public virtual DbSet<BORDEROPAGAMENTO> BORDEROPAGAMENTO { get; set; }

    public virtual DbSet<CAIXA> CAIXA { get; set; }

    public virtual DbSet<CAIXAFORMA> CAIXAFORMA { get; set; }

    public virtual DbSet<CAIXAAUTORIZA> CAIXAAUTORIZA { get; set; }

    public virtual DbSet<CAIXACODIGOEXTERNO> CAIXACODIGOEXTERNO { get; set; }

    public virtual DbSet<CAIXAEMBALAGEM> CAIXAEMBALAGEM { get; set; }

    public virtual DbSet<CAIXAMOEDA> CAIXAMOEDA { get; set; }

    public virtual DbSet<CAIXAOBS> CAIXAOBS { get; set; }

    public virtual DbSet<CAIXARETIRADA> CAIXARETIRADA { get; set; }

    public virtual DbSet<CAMBIO> CAMBIO { get; set; }

    public virtual DbSet<CAMPANHA> CAMPANHA { get; set; }

    public virtual DbSet<CAMPANHACLIENTE> CAMPANHACLIENTE { get; set; }

    public virtual DbSet<CAMPOADICIONAL> CAMPOADICIONAL { get; set; }

    public virtual DbSet<CAMPOADICIONALLISTAVALOR> CAMPOADICIONALLISTAVALOR { get; set; }

    public virtual DbSet<CARTAO> CARTAO { get; set; }

    public virtual DbSet<CARTAOREDE> CARTAOREDE { get; set; }

    public virtual DbSet<CARTAOCONTA> CARTAOCONTA { get; set; }

    public virtual DbSet<CARTAOTAXA> CARTAOTAXA { get; set; }

    public virtual DbSet<CARTEIRABANCO> CARTEIRABANCO { get; set; }

    public virtual DbSet<CARTEIRACOBRANCA> CARTEIRACOBRANCA { get; set; }

    public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }

    public virtual DbSet<CATEGORIANOTICIA> CATEGORIANOTICIA { get; set; }

    public virtual DbSet<CENTRO_CUSTO> CENTRO_CUSTO { get; set; }

    public virtual DbSet<CEST> CEST { get; set; }

    public virtual DbSet<CHEQUES> CHEQUES { get; set; }

    public virtual DbSet<CHEQUESPAGAMENTOS> CHEQUESPAGAMENTOS { get; set; }

    public virtual DbSet<CLAS_FINANCEIRA> CLAS_FINANCEIRA { get; set; }

    public virtual DbSet<CLIENTECHEQUE> CLIENTECHEQUE { get; set; }

    public virtual DbSet<CLIENTECODIGO> CLIENTECODIGO { get; set; }

    public virtual DbSet<CLIENTES> CLIENTES { get; set; }

    public virtual DbSet<CLIENTES_ADICIONAL> CLIENTES_ADICIONAL { get; set; }

    public virtual DbSet<CLIENTESBLOQUEADO> CLIENTESBLOQUEADO { get; set; }

    public virtual DbSet<CLIENTESCOMPLEMENTO> CLIENTESCOMPLEMENTO { get; set; }

    public virtual DbSet<CLIENTESFIDELIDADE> CLIENTESFIDELIDADE { get; set; }

    public virtual DbSet<CLIENTESLIMITES> CLIENTESLIMITES { get; set; }

    public virtual DbSet<CLIENTESOBS> CLIENTESOBS { get; set; }

    public virtual DbSet<CODIGOPRODUTO> CODIGOPRODUTO { get; set; }

    public virtual DbSet<COLECOES> COLECOES { get; set; }

    public virtual DbSet<COMPRADOR> COMPRADOR { get; set; }

    public virtual DbSet<COMPUTADOR> COMPUTADOR { get; set; }

    public virtual DbSet<CONDICOES_PAGAMENTO> CONDICOES_PAGAMENTO { get; set; }

    public virtual DbSet<CONDICOESPRAZOS> CONDICOESPRAZOS { get; set; }

    public virtual DbSet<CONDUTOR> CONDUTOR { get; set; }

    public virtual DbSet<CONFERENCIASEPARACAO> CONFERENCIASEPARACAO { get; set; }

    public virtual DbSet<CONFERENCIASEPARACAOITENS> CONFERENCIASEPARACAOITENS { get; set; }

    public virtual DbSet<CONFIGURACOES> CONFIGURACOES { get; set; }

    public virtual DbSet<CONFIGURAVALORES> CONFIGURAVALORES { get; set; }

    public virtual DbSet<CONSERTO> CONSERTO { get; set; }

    public virtual DbSet<CONSERTOITEM> CONSERTOITEM { get; set; }

    public virtual DbSet<CONSIGNACAO> CONSIGNACAO { get; set; }

    public virtual DbSet<CONSUMO> CONSUMO { get; set; }

    public virtual DbSet<CONSUMOITEM> CONSUMOITEM { get; set; }

    public virtual DbSet<CONTACORRENTE> CONTACORRENTE { get; set; }

    public virtual DbSet<CONTADORES> CONTADORES { get; set; }

    public virtual DbSet<CONTADORFISCAL> CONTADORFISCAL { get; set; }

    public virtual DbSet<CONTAGEM> CONTAGEM { get; set; }

    public virtual DbSet<CONTAGEMITENS> CONTAGEMITENS { get; set; }

    public virtual DbSet<CORES> CORES { get; set; }

    public virtual DbSet<CORESBASICAS> CORESBASICAS { get; set; }

    public virtual DbSet<COTAATACADO> COTAATACADO { get; set; }

    public virtual DbSet<COTAPRODUTO> COTAPRODUTO { get; set; }

    public virtual DbSet<CREDIARIORECEBIMENTO> CREDIARIORECEBIMENTO { get; set; }

    public virtual DbSet<CUSTODIA> CUSTODIA { get; set; }

    public virtual DbSet<DAV> DAV { get; set; }

    public virtual DbSet<DAV_ITENS> DAV_ITENS { get; set; }

    public virtual DbSet<DECORADORES> DECORADORES { get; set; }

    public virtual DbSet<DESCRICAO> DESCRICAO { get; set; }

    public virtual DbSet<DISTRIBUICAO> DISTRIBUICAO { get; set; }

    public virtual DbSet<DISTRIBUICAOC> DISTRIBUICAOC { get; set; }

    public virtual DbSet<DISTRIBUICAOCITENS> DISTRIBUICAOCITENS { get; set; }

    public virtual DbSet<DISTRIBUICAOH> DISTRIBUICAOH { get; set; }

    public virtual DbSet<DIVERGENCIAS> DIVERGENCIAS { get; set; }

    public virtual DbSet<DOCUMENTOSNAOFISCAL> DOCUMENTOSNAOFISCAL { get; set; }

    public virtual DbSet<DUPLICATABOLETO> DUPLICATABOLETO { get; set; }

    public virtual DbSet<DUPLICATARECEBIMENTO> DUPLICATARECEBIMENTO { get; set; }

    public virtual DbSet<DUPLICATAS> DUPLICATAS { get; set; }

    public virtual DbSet<DUPLICATASOBS> DUPLICATASOBS { get; set; }

    public virtual DbSet<ECF_CAIXA> ECF_CAIXA { get; set; }

    public virtual DbSet<ECF_VENDAS> ECF_VENDAS { get; set; }

    public virtual DbSet<EPCPRODUTO> EPCPRODUTO { get; set; }

    public virtual DbSet<EMAILCONFIGURACAO> EMAILCONFIGURACAO { get; set; }

    public virtual DbSet<EMAILCONFIGURACAOFILIAL> EMAILCONFIGURACAOFILIAL { get; set; }

    public virtual DbSet<EMAILCONFIGURACAOFUNCAO> EMAILCONFIGURACAOFUNCAO { get; set; }

    public virtual DbSet<EMBALAGEM> EMBALAGEM { get; set; }

    public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }

    public virtual DbSet<ENDERECO> ENDERECO { get; set; }

    public virtual DbSet<ENDERECOREFERENCIA> ENDERECOREFERENCIA { get; set; }

    public virtual DbSet<ENTRADASAIDA> ENTRADASAIDA { get; set; }

    public virtual DbSet<ENTRADASAIDAH> ENTRADASAIDAH { get; set; }

    public virtual DbSet<ENVIOARQUIVO> ENVIOARQUIVO { get; set; }

    public virtual DbSet<ESTADO> ESTADO { get; set; }

    public virtual DbSet<ESTADOICMS> ESTADOICMS { get; set; }

    public virtual DbSet<ESTOQUEPADRAO> ESTOQUEPADRAO { get; set; }

    public virtual DbSet<ESTOQUES> ESTOQUES { get; set; }

    public virtual DbSet<ESTOQUESERIE> ESTOQUESERIE { get; set; }

    public virtual DbSet<EXTRATO> EXTRATO { get; set; }

    public virtual DbSet<FASE> FASE { get; set; }

    public virtual DbSet<FAVORITO> FAVORITO { get; set; }

    public virtual DbSet<FICHA> FICHA { get; set; }

    public virtual DbSet<FILIAL> FILIAL { get; set; }

    public virtual DbSet<FILIALCOMANDO> FILIALCOMANDO { get; set; }

    public virtual DbSet<FILIALCOMUNICA> FILIALCOMUNICA { get; set; }

    public virtual DbSet<FILIALEMAILFECHAMENTO> FILIALEMAILFECHAMENTO { get; set; }

    public virtual DbSet<FILIALEMAILNEGATIVO> FILIALEMAILNEGATIVO { get; set; }

    public virtual DbSet<PIXFILIALINTEGRACAO> FILIALMATERA { get; set; }

    public virtual DbSet<FILIALMETADIA> FILIALMETADIA { get; set; }

    public virtual DbSet<FILIALMETASEMANA> FILIALMETASEMANA { get; set; }

    public virtual DbSet<FILIALNFELOJA> FILIALNFELOJA { get; set; }

    public virtual DbSet<FILIALSIGEPCONFIGURACAO> FILIALSIGEPCONFIGURACAO { get; set; }

    public virtual DbSet<FILIALTABELA> FILIALTABELA { get; set; }

    public virtual DbSet<FILTROCONFIGURACAO> FILTROCONFIGURACAO { get; set; }

    public virtual DbSet<FILTRODESCRICAO> FILTRODESCRICAO { get; set; }

    public virtual DbSet<FORMAPAGAMENTO> FORMAPAGAMENTO { get; set; }

    public virtual DbSet<FORMASPAGAMENTO> FORMASPAGAMENTO { get; set; }

    public virtual DbSet<FORNECEDORES> FORNECEDORES { get; set; }

    public virtual DbSet<FRANQUIACONF> FRANQUIACONF { get; set; }

    public virtual DbSet<FUNCIONALIDADE> FUNCIONALIDADE { get; set; }

    public virtual DbSet<FUNCIONARIOS> FUNCIONARIOS { get; set; }

    public virtual DbSet<GERENCIAL> GERENCIAL { get; set; }

    public virtual DbSet<GRADE> GRADE { get; set; }

    public virtual DbSet<GRADEATACADO> GRADEATACADO { get; set; }

    public virtual DbSet<GRADEPERCENTUAL> GRADEPERCENTUAL { get; set; }

    public virtual DbSet<GRADESEPARACAO> GRADESEPARACAO { get; set; }

    public virtual DbSet<GRUPO_INVENTARIO> GRUPO_INVENTARIO { get; set; }

    public virtual DbSet<GRUPOCONTA> GRUPOCONTA { get; set; }

    public virtual DbSet<GRUPOFINANCEIRO> GRUPOFINANCEIRO { get; set; }

    public virtual DbSet<GRUPOLOJA> GRUPOLOJA { get; set; }

    public virtual DbSet<GRUPOMATERIAIS> GRUPOMATERIAIS { get; set; }

    public virtual DbSet<GRUPOPRODUCAO> GRUPOPRODUCAO { get; set; }

    public virtual DbSet<HISTORICOPRECO> HISTORICOPRECO { get; set; }

    public virtual DbSet<HISTORICOPRECOPRODUTO> HISTORICOPRECOPRODUTO { get; set; }

    public virtual DbSet<HORARIOVERAO> HORARIOVERAO { get; set; }

    public virtual DbSet<ICMS> ICMS { get; set; }

    public virtual DbSet<IMPRESSAOFILA> IMPRESSAOFILA { get; set; }

    public virtual DbSet<IMPRESSORAFISCAL> IMPRESSORAFISCAL { get; set; }

    public virtual DbSet<PIXTRANSACAO> PIXTRANSACAO { get; set; }

    public virtual DbSet<CAIXAPIX> CAIXAPIX { get; set; }

    public virtual DbSet<INTEGRACAOAGENDAMENTO> INTEGRACAOAGENDAMENTO { get; set; }

    public virtual DbSet<INTEGRACAOCODIGOBARRAS> INTEGRACAOCODIGOBARRAS { get; set; }

    public virtual DbSet<INTEGRACAOCONFIGURACAO> INTEGRACAOCONFIGURACAO { get; set; }

    public virtual DbSet<INTEGRACAOCOR> INTEGRACAOCOR { get; set; }

    public virtual DbSet<INTEGRACAOESTOQUE> INTEGRACAOESTOQUE { get; set; }

    public virtual DbSet<INTEGRACAOFILIALESTOQUE> INTEGRACAOFILIALESTOQUE { get; set; }

    public virtual DbSet<INTEGRACAOGRADE> INTEGRACAOGRADE { get; set; }

    public virtual DbSet<INTEGRACAOIMAGEM> INTEGRACAOIMAGEM { get; set; }

    public virtual DbSet<INTEGRACAOPEDIDO> INTEGRACAOPEDIDO { get; set; }

    public virtual DbSet<INTEGRACAOPRECO> INTEGRACAOPRECO { get; set; }

    public virtual DbSet<INTEGRACAOREFERENCIA> INTEGRACAOREFERENCIA { get; set; }

    public virtual DbSet<INTEGRACAOTAMANHO> INTEGRACAOTAMANHO { get; set; }

    public virtual DbSet<INTEGRACAOTRANSPORTADORAASSOCIACAO> INTEGRACAOTRANSPORTADORAASSOCIACAO { get; set; }

    public virtual DbSet<INTEGRACAOCUPOMFILIAL> INTEGRACAOCUPOMFILIAL { get; set; }

    public virtual DbSet<INTEGRACAOCAMPOEXPORTACAO> INTEGRACAOCAMPOEXPORTACAO { get; set; }

    public virtual DbSet<INTEGRACAOFORMAPAGAMENTO> INTEGRACAOFORMAPAGAMENTO { get; set; }

    public virtual DbSet<INTEGRACAOENTIDADE> INTEGRACAOENTIDADE { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_PRODUCT> INTEG_FOURMIDDLEWARE_PRODUCT { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_VARIATION> INTEG_FOURMIDDLEWARE_VARIATION { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_VARIATION_STOCK> INTEG_FOURMIDDLEWARE_VARIATION_STOCK { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_VARIATION_PRICE> INTEG_FOURMIDDLEWARE_VARIATION_PRICE { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_VARIATION_STATUS> INTEG_FOURMIDDLEWARE_VARIATION_STATUS { get; set; }

    public virtual DbSet<INTEG_FOURMIDDLEWARE_ORDER> INTEG_FOURMIDDLEWARE_ORDER { get; set; }

    public virtual DbSet<INTEG_EZCOMMERCE_SUBVARIACAO> INTEG_EZCOMMERCE_SUBVARIACAO { get; set; }

    public virtual DbSet<INTEG_EZCOMMERCE_PEDIDO> INTEG_EZCOMMERCE_PEDIDO { get; set; }

    public virtual DbSet<INTEG_TRAYCORP_PRODUTO> INTEG_TRAYCORP_PRODUTO { get; set; }

    public virtual DbSet<INTEG_TRAYCORP_VARIACAO> INTEG_TRAYCORP_VARIACAO { get; set; }

    public virtual DbSet<INTEG_TRAYCORP_PEDIDO> INTEG_TRAYCORP_PEDIDO { get; set; }

    public virtual DbSet<INTEG_THULE_PRODUTO> INTEG_THULE_PRODUTO { get; set; }

    public virtual DbSet<INTEG_SKYHUB_ORDER_QUEUE> INTEG_SKYHUB_ORDER_QUEUE { get; set; }

    public virtual DbSet<RETAILAPPCONFIGURACAO> RETAILAPPCONFIGURACAO { get; set; }

    public virtual DbSet<RETAILAPPVENDAENVIADA> RETAILAPPVENDAENVIADA { get; set; }

    public virtual DbSet<INTEGRACAOLUXOTTICA> INTEGRACAOLUXOTTICA { get; set; }

    public virtual DbSet<INVENTARIO> INVENTARIO { get; set; }

    public virtual DbSet<ITENSCONSIGNACAO> ITENSCONSIGNACAO { get; set; }

    public virtual DbSet<ITENSESTOQUEPADRAO> ITENSESTOQUEPADRAO { get; set; }

    public virtual DbSet<ITENSINVENTARIO> ITENSINVENTARIO { get; set; }

    public virtual DbSet<ITENSNOTA> ITENSNOTA { get; set; }

    public virtual DbSet<ITENSNOTASENTRADAS> ITENSNOTASENTRADAS { get; set; }

    public virtual DbSet<ITENSNOTAVENDAS> ITENSNOTAVENDAS { get; set; }

    public virtual DbSet<ITENSPEDIDO> ITENSPEDIDO { get; set; }

    public virtual DbSet<ITENSPEDIDOVENDA> ITENSPEDIDOVENDA { get; set; }

    public virtual DbSet<ITENSSEPARACAO> ITENSSEPARACAO { get; set; }

    public virtual DbSet<ITENSSEPARAVENDA> ITENSSEPARAVENDA { get; set; }

    public virtual DbSet<ITICONTRATO> ITICONTRATO { get; set; }

    public virtual DbSet<LANCAMENTOCONTA> LANCAMENTOCONTA { get; set; }

    public virtual DbSet<KIT> KIT { get; set; }

    public virtual DbSet<KITPRECO> KITPRECO { get; set; }

    public virtual DbSet<LINHA> LINHA { get; set; }

    public virtual DbSet<MANIFESTOELETRONICO> MANIFESTOELETRONICO { get; set; }

    public virtual DbSet<MANIFESTOELETRONICOCHAVE> MANIFESTOELETRONICOCHAVE { get; set; }

    public virtual DbSet<MANIFESTOELETRONICOCONDUTOR> MANIFESTOELETRONICOCONDUTOR { get; set; }

    public virtual DbSet<MANIFESTOELETRONICOPERCURSO> MANIFESTOELETRONICOPERCURSO { get; set; }

    public virtual DbSet<MATERIAIS> MATERIAIS { get; set; }

    public virtual DbSet<MATERIAIS_LOCALIZACAO> MATERIAIS_LOCALIZACAO { get; set; }

    public virtual DbSet<MATERIAISCONVERSAO> MATERIAISCONVERSAO { get; set; }

    public virtual DbSet<MATERIAISCOR> MATERIAISCOR { get; set; }

    public virtual DbSet<MATERIAISCORSEQ> MATERIAISCORSEQ { get; set; }

    public virtual DbSet<MATERIAISLOCALIZACAO> MATERIAISLOCALIZACAO { get; set; }

    public virtual DbSet<MATERIALCOR> MATERIALCOR { get; set; }

    public virtual DbSet<MATERIALPRODUCAO> MATERIALPRODUCAO { get; set; }

    public virtual DbSet<MATERIAPRIMA> MATERIAPRIMA { get; set; }

    public virtual DbSet<META> META { get; set; }

    public virtual DbSet<METADIA> METADIA { get; set; }

    public virtual DbSet<METAFORMA> METAFORMA { get; set; }

    public virtual DbSet<METAPRODUTO> METAPRODUTO { get; set; }

    public virtual DbSet<METAVALOR> METAVALOR { get; set; }

    public virtual DbSet<MODELOS> MODELOS { get; set; }

    public virtual DbSet<MOEDAS> MOEDAS { get; set; }

    public virtual DbSet<MOTIVOBAIXA> MOTIVOBAIXA { get; set; }

    public virtual DbSet<MOTIVOLOJA> MOTIVOLOJA { get; set; }

    public virtual DbSet<MOVIMENTACAOESTOQUE> MOVIMENTACAOESTOQUE { get; set; }

    public virtual DbSet<MUNICIPIO> MUNICIPIO { get; set; }

    public virtual DbSet<NCM> NCM { get; set; }

    public virtual DbSet<NFE_LOTE> NFE_LOTE { get; set; }

    public virtual DbSet<NF_CFOP> NF_CFOP { get; set; }

    public virtual DbSet<NFECARTACORRECAO> NFECARTACORRECAO { get; set; }

    public virtual DbSet<NFECARTACORRECAOLOTE> NFECARTACORRECAOLOTE { get; set; }

    public virtual DbSet<NFEREFERENCIADA> NFEREFERENCIADA { get; set; }

    public virtual DbSet<NFEWS> NFEWS { get; set; }

    public virtual DbSet<NOTA_FISCAL> NOTA_FISCAL { get; set; }

    public virtual DbSet<NOTA_FISCAL_RASTREIO> NOTA_FISCAL_RASTREIO { get; set; }

    public virtual DbSet<NOTAFISCALSERVICO> NOTAFISCALSERVICO { get; set; }

    public virtual DbSet<NOTACREDITO> NOTACREDITO { get; set; }

    public virtual DbSet<NOTAINUTILIZADA> NOTAINUTILIZADA { get; set; }

    public virtual DbSet<NOTAREJEITADA> NOTAREJEITADA { get; set; }

    public virtual DbSet<NOTASENTRADAS> NOTASENTRADAS { get; set; }

    public virtual DbSet<NOTASENTRADASCONHECIMENTO> NOTASENTRADASCONHECIMENTO { get; set; }

    public virtual DbSet<NOTASENTRADASSERIE> NOTASENTRADASSERIE { get; set; }

    public virtual DbSet<NOTICIAS> NOTICIAS { get; set; }

    public virtual DbSet<NOTICIAUSUARIO> NOTICIAUSUARIO { get; set; }

    public virtual DbSet<PAGAMENTOS> PAGAMENTOS { get; set; }

    public virtual DbSet<PAIS> PAIS { get; set; }

    public virtual DbSet<PARCELAS> PARCELAS { get; set; }

    public virtual DbSet<PARCELAS_CARTAO> PARCELAS_CARTAO { get; set; }

    public virtual DbSet<PARENTESCO> PARENTESCO { get; set; }

    public virtual DbSet<PEDIDOETIQUETA> PEDIDOETIQUETA { get; set; }

    public virtual DbSet<PEDIDOS> PEDIDOS { get; set; }

    public virtual DbSet<PEDIDOSVENDA> PEDIDOSVENDA { get; set; }

    public virtual DbSet<PIX> PIX { get; set; }

    public virtual DbSet<PRECO> PRECO { get; set; }

    public virtual DbSet<PRODUTONEGATIVO> PRODUTONEGATIVO { get; set; }

    public virtual DbSet<PRODUTOSOLICITACAO> PRODUTOSOLICITACAO { get; set; }

    public virtual DbSet<PROFISSAO> PROFISSAO { get; set; }

    public virtual DbSet<PROMOCAOPECAS> PROMOCAOPECAS { get; set; }

    public virtual DbSet<RECEBEARQUIVO> RECEBEARQUIVO { get; set; }

    public virtual DbSet<RECEBER> RECEBER { get; set; }

    public virtual DbSet<REFERENCIACATEGORIA> REFERENCIACATEGORIA { get; set; }

    public virtual DbSet<REFERENCIAINTEGRACAO> REFERENCIAINTEGRACAO { get; set; }

    public virtual DbSet<REFERENCIAS> REFERENCIAS { get; set; }

    public virtual DbSet<REFERENCIAS_ADICIONAL> REFERENCIAS_ADICIONAL { get; set; }

    public virtual DbSet<REFERENCIASCOMENTARIOS> REFERENCIASCOMENTARIOS { get; set; }

    public virtual DbSet<REFERENCIASITE> REFERENCIASITE { get; set; }

    public virtual DbSet<REGIAO> REGIAO { get; set; }

    public virtual DbSet<REGISTROBONUS> REGISTROBONUS { get; set; }

    public virtual DbSet<REGISTROPROMOCAO> REGISTROPROMOCAO { get; set; }

    public virtual DbSet<REGRAS> REGRAS { get; set; }

    public virtual DbSet<REMANEJA> REMANEJA { get; set; }

    public virtual DbSet<REMESSA> REMESSA { get; set; }

    public virtual DbSet<REMESSACARTEIRA> REMESSACARTEIRA { get; set; }

    public virtual DbSet<REMESSACONFIGURACAO> REMESSACONFIGURACAO { get; set; }

    public virtual DbSet<REMESSAINSTRUCAO> REMESSAINSTRUCAO { get; set; }

    public virtual DbSet<REPRESENTANTE> REPRESENTANTE { get; set; }

    public virtual DbSet<REPRESENTANTEREDE> REPRESENTANTEREDE { get; set; }

    public virtual DbSet<REPRESENTANTETABELA> REPRESENTANTETABELA { get; set; }

    public virtual DbSet<RESUMOFORMA> RESUMOFORMA { get; set; }

    public virtual DbSet<RETORNO_ERROS> RETORNO_ERROS { get; set; }

    public virtual DbSet<RETORNO_OCORRENCIA> RETORNO_OCORRENCIA { get; set; }

    public virtual DbSet<ROTA> ROTA { get; set; }

    public virtual DbSet<ROTAFASE> ROTAFASE { get; set; }

    public virtual DbSet<SALDOS> SALDOS { get; set; }

    public virtual DbSet<SALDOSC> SALDOSC { get; set; }

    public virtual DbSet<SEPARACAOPEDIDO> SEPARACAOPEDIDO { get; set; }

    public virtual DbSet<SEPARAVENDA> SEPARAVENDA { get; set; }

    public virtual DbSet<SETOR> SETOR { get; set; }

    public virtual DbSet<SINCRONIZACAOLOG> SINCRONIZACAOLOG { get; set; }

    public virtual DbSet<SINCRONIZACAOTABELA> SINCRONIZACAOTABELA { get; set; }

    public virtual DbSet<SINCRONIZACAOTABELALOG> SINCRONIZACAOTABELALOG { get; set; }

    public virtual DbSet<SITECATEGORIA> SITECATEGORIA { get; set; }

    public virtual DbSet<SOLICITACAOAUTORIZACAO> SOLICITACAOAUTORIZACAO { get; set; }

    public virtual DbSet<SUBGRUPO> SUBGRUPO { get; set; }

    public virtual DbSet<STATUS> STATUS { get; set; }

    public virtual DbSet<TABELAPRECO> TABELAPRECO { get; set; }

    public virtual DbSet<TABELATRIBUTO> TABELATRIBUTO { get; set; }

    public virtual DbSet<TAMANHOS> TAMANHOS { get; set; }

    public virtual DbSet<TAREFAS> TAREFAS { get; set; }

    public virtual DbSet<TAREFASEXECUTADAS> TAREFASEXECUTADAS { get; set; }

    public virtual DbSet<TAREFASFILIAL> TAREFASFILIAL { get; set; }

    public virtual DbSet<TAREFASTIPO> TAREFASTIPO { get; set; }

    public virtual DbSet<TEFNOVA> TEFNOVA { get; set; }

    public virtual DbSet<TIPOCLIENTE> TIPOCLIENTE { get; set; }

    public virtual DbSet<TIPODESCONTO> TIPODESCONTO { get; set; }

    public virtual DbSet<TIPONOTA> TIPONOTA { get; set; }

    public virtual DbSet<TIPOPRODUCAO> TIPOPRODUCAO { get; set; }

    public virtual DbSet<TRANSFERENCIAOBS> TRANSFERENCIAOBS { get; set; }

    public virtual DbSet<TRANSPORTADORAS> TRANSPORTADORAS { get; set; }

    public virtual DbSet<UNIDADES> UNIDADES { get; set; }

    public virtual DbSet<USUARIOCOLUNA> USUARIOCOLUNA { get; set; }

    public virtual DbSet<USUARIOFILIAL> USUARIOFILIAL { get; set; }

    public virtual DbSet<USUARIOS> USUARIOS { get; set; }

    public virtual DbSet<USUARIOTELADESENHO> USUARIOTELADESENHO { get; set; }

    public virtual DbSet<VALES> VALES { get; set; }

    public virtual DbSet<VEICULO> VEICULO { get; set; }

    public virtual DbSet<VENDAS> VENDAS { get; set; }

    public virtual DbSet<VENDASENTREGA> VENDASENTREGA { get; set; }

    public virtual DbSet<VENDASSERIE> VENDASSERIE { get; set; }

    public virtual DbSet<VENDEDORES> VENDEDORES { get; set; }

    public virtual DbSet<VERSOES> VERSOES { get; set; }

    public virtual DbSet<APROVEITAMENTO> APROVEITAMENTO { get; set; }

    public virtual DbSet<DEPENDENTE> DEPENDENTE { get; set; }

    public virtual DbSet<DEVOLUCAOATACADO> DEVOLUCAOATACADO { get; set; }

    public virtual DbSet<MATERIAISPROMOCAO> MATERIAISPROMOCAO { get; set; }

    public virtual DbSet<PROMOCAOFILIAL> PROMOCAOFILIAL { get; set; }

    public virtual DbSet<METAFORMADIA> METAFORMADIA { get; set; }

    public virtual DbSet<METAVENDEDOR> METAVENDEDOR { get; set; }

    public virtual DbSet<NUMERO_NOTA> NUMERO_NOTA { get; set; }

    public virtual DbSet<TAREFASDIAS> TAREFASDIAS { get; set; }

    public virtual DbSet<TRIBUTO> TRIBUTO { get; set; }

    public virtual DbSet<WMSCAIXA> WMSCAIXA { get; set; }

    public virtual DbSet<WMSLOCAL> WMSLOCAL { get; set; }

    public virtual DbSet<WMSENDERECO> WMSENDERECO { get; set; }

    public virtual DbSet<WMSTIPO> WMSTIPO { get; set; }

    public virtual DbSet<TabelaTeste> TabelaTeste { get; set; }



    public ModeloPDV(string stringConexao) : base(stringConexao)
    {
        base.Configuration.AutoDetectChangesEnabled = false;
        base.Configuration.LazyLoadingEnabled = false;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        modelBuilder.Entity<AUTORES>().Property((AUTORES e) => e.AUT_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BANCOS>().Property((BANCOS e) => e.BAN_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BANCOS>().Property((BANCOS e) => e.BAN_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BATIMENTOS>().Property((BATIMENTOS e) => e.BAT_ROMANEIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BATIMENTOS>().Property((BATIMENTOS e) => e.BAT_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUS>().Property((BONUS e) => e.BON_BONUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUS>().Property((BONUS e) => e.BON_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUS>().Property((BONUS e) => e.BON_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUS>().Property((BONUS e) => e.BON_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUSBOLETA>().Property((BONUSBOLETA e) => e.BOB_BONUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUSBOLETA>().Property((BONUSBOLETA e) => e.BOB_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUSEXTRATOPONTUACAO>().Property((BONUSEXTRATOPONTUACAO e) => e.BEP_CAIXA_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BONUSEXTRATOPONTUACAO>().Property((BONUSEXTRATOPONTUACAO e) => e.BEP_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BORDERO>().Property((BORDERO e) => e.BOR_CUSTODIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BORDERO>().Property((BORDERO e) => e.BOR_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BORDERO>().Property((BORDERO e) => e.BOR_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<BORDEROPAGAMENTO>().Property((BORDEROPAGAMENTO e) => e.BPG_PAGAMENTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_RETIRADA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_DECORADOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_CPF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXA>().Property((CAIXA e) => e.CAI_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAAUTORIZA>().Property((CAIXAAUTORIZA e) => e.CAA_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAAUTORIZA>().Property((CAIXAAUTORIZA e) => e.CAA_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAEMBALAGEM>().Property((CAIXAEMBALAGEM e) => e.CAE_EMBALAGEM).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAEMBALAGEM>().Property((CAIXAEMBALAGEM e) => e.CAE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAMOEDA>().Property((CAIXAMOEDA e) => e.CAM_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAOBS>().Property((CAIXAOBS e) => e.CAO_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXAOBS>().Property((CAIXAOBS e) => e.CAO_OBS).IsUnicode(false);
        modelBuilder.Entity<CAIXARETIRADA>().Property((CAIXARETIRADA e) => e.CAR_FUNCIONARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAIXARETIRADA>().Property((CAIXARETIRADA e) => e.CAR_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAMBIO>().Property((CAMBIO e) => e.CAM_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAMPANHA>().Property((CAMPANHA e) => e.CAM_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CAMPANHA>().Property((CAMPANHA e) => e.CAM_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CAMPANHACLIENTE>().Property((CAMPANHACLIENTE e) => e.CAC_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CAMPANHACLIENTE>().Property((CAMPANHACLIENTE e) => e.CAC_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CAMPOADICIONAL>().Property((CAMPOADICIONAL e) => e.CAM_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CAMPOADICIONAL>().Property((CAMPOADICIONAL e) => e.CAM_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CAMPOADICIONAL>().Property((CAMPOADICIONAL e) => e.CAM_NOME_CAMPO).IsUnicode(false);
        modelBuilder.Entity<CAMPOADICIONALLISTAVALOR>().Property((CAMPOADICIONALLISTAVALOR e) => e.CLV_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CAMPOADICIONALLISTAVALOR>().Property((CAMPOADICIONALLISTAVALOR e) => e.CLV_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CARTAO>().Property((CARTAO e) => e.CAR_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CARTAO>().Property((CARTAO e) => e.CAR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CARTAOCONTA>().Property((CARTAOCONTA e) => e.CAR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CARTEIRABANCO>().Property((CARTEIRABANCO e) => e.CAB_BANCO).IsUnicode(false);
        modelBuilder.Entity<CARTEIRABANCO>().Property((CARTEIRABANCO e) => e.CAB_CARTEIRA_BANCO).IsUnicode(false);
        modelBuilder.Entity<CARTEIRACOBRANCA>().Property((CARTEIRACOBRANCA e) => e.CCB_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CATEGORIANOTICIA>().Property((CATEGORIANOTICIA e) => e.CAT_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CENTRO_CUSTO>().Property((CENTRO_CUSTO e) => e.CEN_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CENTRO_CUSTO>().Property((CENTRO_CUSTO e) => e.CEN_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CHEQUES>().Property((CHEQUES e) => e.CHE_HISTORICO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CHEQUES>().Property((CHEQUES e) => e.CHE_STATUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CHEQUES>().Property((CHEQUES e) => e.CHE_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CHEQUES>().Property((CHEQUES e) => e.CHE_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CHEQUESPAGAMENTOS>().Property((CHEQUESPAGAMENTOS e) => e.REL_PAGAMENTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_GRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_GERENCIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLAS_FINANCEIRA>().Property((CLAS_FINANCEIRA e) => e.CLA_FISCAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTECODIGO>().Property((CLIENTECODIGO e) => e.CCO_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTECODIGO>().Property((CLIENTECODIGO e) => e.CCO_ANTERIOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTECODIGO>().Property((CLIENTECODIGO e) => e.CCO_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTECODIGO>().Property((CLIENTECODIGO e) => e.CCO_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_CELULAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_COMERCIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_PAI).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_MAE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_IDENTIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_VENDEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES>().Property((CLIENTES e) => e.CLI_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTES_ADICIONAL>().Property((CLIENTES_ADICIONAL e) => e.CAD_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESBLOQUEADO>().Property((CLIENTESBLOQUEADO e) => e.CLB_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESBLOQUEADO>().Property((CLIENTESBLOQUEADO e) => e.CLB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_FANTASIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_INSCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_REFERENCIA1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CONTATO_REF1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_DDD_REF1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_TEL_REF1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_REFERENCIA2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CONTATO_REF2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_DDD_REF2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_TEL_REF2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_REFERENCIA3).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CONTATO_REF3).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_DDD_REF3).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_TEL_REF3).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CONTATO1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_CONTATO2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_COMPRA_REF1).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_COMPRA_REF2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_COMPRA_REF3).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_OBS_F).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESCOMPLEMENTO>().Property((CLIENTESCOMPLEMENTO e) => e.CLC_SUFRAMA).IsUnicode(false);
        modelBuilder.Entity<CLIENTESFIDELIDADE>().Property((CLIENTESFIDELIDADE e) => e.CLF_CARTAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESFIDELIDADE>().Property((CLIENTESFIDELIDADE e) => e.CLF_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESFIDELIDADE>().Property((CLIENTESFIDELIDADE e) => e.CLF_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESLIMITES>().Property((CLIENTESLIMITES e) => e.CLL_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESLIMITES>().Property((CLIENTESLIMITES e) => e.CLL_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CLIENTESOBS>().Property((CLIENTESOBS e) => e.CLO_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CODIGOPRODUTO>().Property((CODIGOPRODUTO e) => e.COD_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CODIGOPRODUTO>().Property((CODIGOPRODUTO e) => e.COD_ORIGINAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CODIGOPRODUTO>().Property((CODIGOPRODUTO e) => e.COD_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COLECOES>().Property((COLECOES e) => e.COL_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COLECOES>().Property((COLECOES e) => e.COL_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COMPRADOR>().Property((COMPRADOR e) => e.COM_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COMPRADOR>().Property((COMPRADOR e) => e.COM_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COMPUTADOR>().Property((COMPUTADOR e) => e.COM_SERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COMPUTADOR>().Property((COMPUTADOR e) => e.COM_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONDICOES_PAGAMENTO>().Property((CONDICOES_PAGAMENTO e) => e.CON_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONDICOES_PAGAMENTO>().Property((CONDICOES_PAGAMENTO e) => e.CON_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONFERENCIASEPARACAO>().Property((CONFERENCIASEPARACAO e) => e.COS_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONFERENCIASEPARACAO>().Property((CONFERENCIASEPARACAO e) => e.COS_SERIAL).IsUnicode(false);
        modelBuilder.Entity<CONFERENCIASEPARACAOITENS>().Property((CONFERENCIASEPARACAOITENS e) => e.COI_PRODUTO).IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_VENDEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSIGNACAO>().Property((CONSIGNACAO e) => e.CON_DECORADOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSUMO>().Property((CONSUMO e) => e.CON_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSUMO>().Property((CONSUMO e) => e.CON_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<CONSUMOITEM>().Property((CONSUMOITEM e) => e.COI_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONSUMOITEM>().Property((CONSUMOITEM e) => e.COI_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_GERENTE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_ULTIMO_CHEQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_GRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_MENSAGEM).IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_INSTRUCAO1).IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_INSTRUCAO2).IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_CODIGO_TRANSMISSAO).IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_COMPLEMENTO).IsUnicode(false);
        modelBuilder.Entity<CONTACORRENTE>().Property((CONTACORRENTE e) => e.CON_ULTIMO_NOSSO_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_CPF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_CRC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_CNPJ).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORES>().Property((CONTADORES e) => e.CON_CHAVE).IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_REDUCAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_REINICIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_COOINICIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_COOFINAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_COO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_US_ALTERACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTADORFISCAL>().Property((CONTADORFISCAL e) => e.CON_SERIAL).IsUnicode(false);
        modelBuilder.Entity<CONTAGEM>().Property((CONTAGEM e) => e.CON_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTAGEM>().Property((CONTAGEM e) => e.CON_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTAGEM>().Property((CONTAGEM e) => e.CON_SERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CONTAGEMITENS>().Property((CONTAGEMITENS e) => e.ITC_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CORES>().Property((CORES e) => e.COR_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CORES>().Property((CORES e) => e.COR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CORESBASICAS>().Property((CORESBASICAS e) => e.COB_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<CORESBASICAS>().Property((CORESBASICAS e) => e.COB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CORESBASICAS>().Property((CORESBASICAS e) => e.COB_RGB).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COTAATACADO>().Property((COTAATACADO e) => e.COT_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COTAATACADO>().Property((COTAATACADO e) => e.COT_TIPO_CLIENTE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COTAATACADO>().Property((COTAATACADO e) => e.COT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COTAPRODUTO>().Property((COTAPRODUTO e) => e.COP_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<COTAPRODUTO>().Property((COTAPRODUTO e) => e.COP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_DOC_BAIXA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_CREDIARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CREDIARIORECEBIMENTO>().Property((CREDIARIORECEBIMENTO e) => e.CRB_CHEQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CUSTODIA>().Property((CUSTODIA e) => e.CUS_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<CUSTODIA>().Property((CUSTODIA e) => e.CUS_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_CAIXA).IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_DOC_CAIXA).IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_NOME).IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_VENDEDOR).IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_CODIGON).IsUnicode(false);
        modelBuilder.Entity<DAV>().Property((DAV e) => e.DAV_MATRICULA_AUTORIZA).IsUnicode(false);
        modelBuilder.Entity<DAV_ITENS>().Property((DAV_ITENS e) => e.DAI_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DAV_ITENS>().Property((DAV_ITENS e) => e.DAI_PRODUTO).IsUnicode(false);
        modelBuilder.Entity<DAV_ITENS>().Property((DAV_ITENS e) => e.DAI_SITUACAO).IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_CPF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_IDENTIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_PROFISSAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_CELULAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DECORADORES>().Property((DECORADORES e) => e.DEC_CHAVE).IsUnicode(false);
        modelBuilder.Entity<DESCRICAO>().Property((DESCRICAO e) => e.DES_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DESCRICAO>().Property((DESCRICAO e) => e.DES_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DESCRICAO>().Property((DESCRICAO e) => e.DES_UNIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DESCRICAO>().Property((DESCRICAO e) => e.DES_NOTA_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DESCRICAO>().Property((DESCRICAO e) => e.DES_NCM).IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAO>().Property((DISTRIBUICAO e) => e.DIS_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAO>().Property((DISTRIBUICAO e) => e.DIS_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAO>().Property((DISTRIBUICAO e) => e.DIS_RAZAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOC>().Property((DISTRIBUICAOC e) => e.DIC_ROMANEIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOC>().Property((DISTRIBUICAOC e) => e.DIC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOC>().Property((DISTRIBUICAOC e) => e.DIC_SERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOCITENS>().Property((DISTRIBUICAOCITENS e) => e.DCI_ROMANEIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOCITENS>().Property((DISTRIBUICAOCITENS e) => e.DCI_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOH>().Property((DISTRIBUICAOH e) => e.DIH_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DISTRIBUICAOH>().Property((DISTRIBUICAOH e) => e.DIH_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DIVERGENCIAS>().Property((DIVERGENCIAS e) => e.DIV_INVENTARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DIVERGENCIAS>().Property((DIVERGENCIAS e) => e.DIV_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_COO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_GNF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_GRG).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_CDC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_DENOMINACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_HORA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_SERIAL).IsUnicode(false);
        modelBuilder.Entity<DOCUMENTOSNAOFISCAL>().Property((DOCUMENTOSNAOFISCAL e) => e.DOC_CAI_DOC).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_DUPLICATA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_CONTA).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_DOCUMENTO).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_NOSSO_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_LINHA_DIGITAVEL).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_CODIGO_BARRAS).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_CODIGO_CEDENTE).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_CARTEIRA).IsUnicode(false);
        modelBuilder.Entity<DUPLICATABOLETO>().Property((DUPLICATABOLETO e) => e.DUB_NOTA_DOC).IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_DOC_BAIXA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_DUPLICATA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_CONTA_DESTINO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATARECEBIMENTO>().Property((DUPLICATARECEBIMENTO e) => e.DUR_CHEQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_DUPLICATA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_PARCELAS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_NOTA_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_CUSTODIA).IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_NUMERO_CONTROLE).IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_NOSSO_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_INSTRUCAO1).IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_INSTRUCAO2).IsUnicode(false);
        modelBuilder.Entity<DUPLICATAS>().Property((DUPLICATAS e) => e.DUP_SEU_NUMERO).IsUnicode(false);
        modelBuilder.Entity<DUPLICATASOBS>().Property((DUPLICATASOBS e) => e.DUO_DUPLICATA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DUPLICATASOBS>().Property((DUPLICATASOBS e) => e.DUO_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_RETIRADA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_STATUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_SERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_SERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_SUBSERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_CCF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_CAIXA>().Property((ECF_CAIXA e) => e.CAI_DOC).IsUnicode(false);
        modelBuilder.Entity<ECF_VENDAS>().Property((ECF_VENDAS e) => e.VEN_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_VENDAS>().Property((ECF_VENDAS e) => e.VEN_SITUACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_VENDAS>().Property((ECF_VENDAS e) => e.VEN_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ECF_VENDAS>().Property((ECF_VENDAS e) => e.VEN_TOTALIZADOR).IsUnicode(false);
        modelBuilder.Entity<EMBALAGEM>().Property((EMBALAGEM e) => e.EMB_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMBALAGEM>().Property((EMBALAGEM e) => e.EMB_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMBALAGEM>().Property((EMBALAGEM e) => e.EMB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_RAZAO_SOCIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_COMPOSICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_SEQ).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_RAMO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_COMPOSICAO_BARRA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_DIR_FOTOS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EMPRESAS>().Property((EMPRESAS e) => e.EMP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_CEP).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_ENDERECO).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_NUMERO).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_COMPLEMENTO).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_BAIRRO).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_CIDADE).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_UF).IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_PAIS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENDERECO>().Property((ENDERECO e) => e.END_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENDERECOREFERENCIA>().Property((ENDERECOREFERENCIA e) => e.ENR_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENDERECOREFERENCIA>().Property((ENDERECOREFERENCIA e) => e.ENR_REFERENCIA).IsUnicode(false);
        modelBuilder.Entity<ENTRADASAIDA>().Property((ENTRADASAIDA e) => e.ENT_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENTRADASAIDA>().Property((ENTRADASAIDA e) => e.ENT_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENTRADASAIDAH>().Property((ENTRADASAIDAH e) => e.ENH_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENTRADASAIDAH>().Property((ENTRADASAIDAH e) => e.ENH_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENTRADASAIDAH>().Property((ENTRADASAIDAH e) => e.ENH_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENVIOARQUIVO>().Property((ENVIOARQUIVO e) => e.ENV_DADOS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENVIOARQUIVO>().Property((ENVIOARQUIVO e) => e.ENV_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ENVIOARQUIVO>().Property((ENVIOARQUIVO e) => e.ENV_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTADO>().Property((ESTADO e) => e.EST_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTADOICMS>().Property((ESTADOICMS e) => e.ESI_ORIGEM).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTADOICMS>().Property((ESTADOICMS e) => e.ESI_DESTINO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUEPADRAO>().Property((ESTOQUEPADRAO e) => e.ESP_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUEPADRAO>().Property((ESTOQUEPADRAO e) => e.ESP_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUEPADRAO>().Property((ESTOQUEPADRAO e) => e.ESP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUES>().Property((ESTOQUES e) => e.EST_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUES>().Property((ESTOQUES e) => e.EST_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUES>().Property((ESTOQUES e) => e.EST_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUESERIE>().Property((ESTOQUESERIE e) => e.EST_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ESTOQUESERIE>().Property((ESTOQUESERIE e) => e.EST_SERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_OPERACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_PAGAMENTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_RECEBER).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_LANCAMENTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_CCUSTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<EXTRATO>().Property((EXTRATO e) => e.EXT_CLASS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FASE>().Property((FASE e) => e.FAS_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FASE>().Property((FASE e) => e.FAS_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FASE>().Property((FASE e) => e.FAS_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FAVORITO>().Property((FAVORITO e) => e.FAV_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FAVORITO>().Property((FAVORITO e) => e.FAV_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<FAVORITO>().Property((FAVORITO e) => e.FAV_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<FICHA>().Property((FICHA e) => e.FIC_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FICHA>().Property((FICHA e) => e.FIC_MATERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FICHA>().Property((FICHA e) => e.FIC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_RAZAO_SOCIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_INSCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_ATIVA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_RAZAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_CONTATO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_CCUSTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_INSCRICAO_MUNICIPAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_INSCRICAO_EST_S).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_CHAVE).IsUnicode(false);
        modelBuilder.Entity<FILIAL>().Property((FILIAL e) => e.FIL_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<FILIALCOMANDO>().Property((FILIALCOMANDO e) => e.FIC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALCOMUNICA>().Property((FILIALCOMUNICA e) => e.FIC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALEMAILFECHAMENTO>().Property((FILIALEMAILFECHAMENTO e) => e.FIF_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALEMAILFECHAMENTO>().Property((FILIALEMAILFECHAMENTO e) => e.FIF_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALEMAILNEGATIVO>().Property((FILIALEMAILNEGATIVO e) => e.FIN_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALEMAILNEGATIVO>().Property((FILIALEMAILNEGATIVO e) => e.FIN_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILIALTABELA>().Property((FILIALTABELA e) => e.FIT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FILTRODESCRICAO>().Property((FILTRODESCRICAO e) => e.FID_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<FORMASPAGAMENTO>().Property((FORMASPAGAMENTO e) => e.FOR_IMPRESSORA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORMASPAGAMENTO>().Property((FORMASPAGAMENTO e) => e.FOR_FORMA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORMASPAGAMENTO>().Property((FORMASPAGAMENTO e) => e.FOR_CONFIGURACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_INSCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CONTATO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CARGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CONSIGNACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_FANTASIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_TIPO_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CELULAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_TELEFONE2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_CHAVE).IsUnicode(false);
        modelBuilder.Entity<FORNECEDORES>().Property((FORNECEDORES e) => e.FOR_SITE).IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_APELIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_CPF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_IDENTIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_PROFISSAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_CHAVE).IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_AGENCIA).IsUnicode(false);
        modelBuilder.Entity<FUNCIONARIOS>().Property((FUNCIONARIOS e) => e.FUN_CONTA).IsUnicode(false);
        modelBuilder.Entity<GERENCIAL>().Property((GERENCIAL e) => e.GER_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GERENCIAL>().Property((GERENCIAL e) => e.GER_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADE>().Property((GRADE e) => e.GRA_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADE>().Property((GRADE e) => e.GRA_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADEATACADO>().Property((GRADEATACADO e) => e.GRA_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADEATACADO>().Property((GRADEATACADO e) => e.GRA_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADEPERCENTUAL>().Property((GRADEPERCENTUAL e) => e.GRA_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADEPERCENTUAL>().Property((GRADEPERCENTUAL e) => e.GRA_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRADESEPARACAO>().Property((GRADESEPARACAO e) => e.GRA_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPO_INVENTARIO>().Property((GRUPO_INVENTARIO e) => e.INVG_INVENTARIO);
        modelBuilder.Entity<GRUPO_INVENTARIO>().Property((GRUPO_INVENTARIO e) => e.INVG_GRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOCONTA>().Property((GRUPOCONTA e) => e.GRU_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOCONTA>().Property((GRUPOCONTA e) => e.GRU_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOFINANCEIRO>().Property((GRUPOFINANCEIRO e) => e.GRU_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOFINANCEIRO>().Property((GRUPOFINANCEIRO e) => e.GRU_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOFINANCEIRO>().Property((GRUPOFINANCEIRO e) => e.GRU_FISCAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOFINANCEIRO>().Property((GRUPOFINANCEIRO e) => e.GRU_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOLOJA>().Property((GRUPOLOJA e) => e.GRU_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOLOJA>().Property((GRUPOLOJA e) => e.GRU_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOMATERIAIS>().Property((GRUPOMATERIAIS e) => e.GRUM_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOMATERIAIS>().Property((GRUPOMATERIAIS e) => e.GRUM_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOMATERIAIS>().Property((GRUPOMATERIAIS e) => e.GRUM_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOPRODUCAO>().Property((GRUPOPRODUCAO e) => e.GRP_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOPRODUCAO>().Property((GRUPOPRODUCAO e) => e.GRP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<GRUPOPRODUCAO>().Property((GRUPOPRODUCAO e) => e.GRP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HISTORICOPRECO>().Property((HISTORICOPRECO e) => e.HIS_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HISTORICOPRECO>().Property((HISTORICOPRECO e) => e.HIS_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HISTORICOPRECOPRODUTO>().Property((HISTORICOPRECOPRODUTO e) => e.HIS_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HISTORICOPRECOPRODUTO>().Property((HISTORICOPRECOPRODUTO e) => e.HIS_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HORARIOVERAO>().Property((HORARIOVERAO e) => e.HOV_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<HORARIOVERAO>().Property((HORARIOVERAO e) => e.HOV_ESTADOS).IsUnicode(false);
        modelBuilder.Entity<ICMS>().Property((ICMS e) => e.ICMS_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_SERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_MARCA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_MODELO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_MFADICIONAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_VERSAOSB).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<IMPRESSORAFISCAL>().Property((IMPRESSORAFISCAL e) => e.IMP_IDNACIONAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<INVENTARIO>().Property((INVENTARIO e) => e.INV_CODIGO);
        modelBuilder.Entity<INVENTARIO>().Property((INVENTARIO e) => e.INV_RESPONSAVEL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<INVENTARIO>().Property((INVENTARIO e) => e.INV_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSCONSIGNACAO>().Property((ITENSCONSIGNACAO e) => e.ITC_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSCONSIGNACAO>().Property((ITENSCONSIGNACAO e) => e.ITC_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSCONSIGNACAO>().Property((ITENSCONSIGNACAO e) => e.ITC_BOLETA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSCONSIGNACAO>().Property((ITENSCONSIGNACAO e) => e.ITC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSCONSIGNACAO>().Property((ITENSCONSIGNACAO e) => e.ITC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSESTOQUEPADRAO>().Property((ITENSESTOQUEPADRAO e) => e.IEP_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSESTOQUEPADRAO>().Property((ITENSESTOQUEPADRAO e) => e.IEP_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSINVENTARIO>().Property((ITENSINVENTARIO e) => e.ITV_INVENTARIO);
        modelBuilder.Entity<ITENSINVENTARIO>().Property((ITENSINVENTARIO e) => e.ITV_LOTE);
        modelBuilder.Entity<ITENSINVENTARIO>().Property((ITENSINVENTARIO e) => e.ITV_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTA>().Property((ITENSNOTA e) => e.ITE_MATERIAL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTA>().Property((ITENSNOTA e) => e.ITE_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTA>().Property((ITENSNOTA e) => e.ITE_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTA>().Property((ITENSNOTA e) => e.ITE_CST_ICMS).IsUnicode(false);
        modelBuilder.Entity<ITENSNOTA>().Property((ITENSNOTA e) => e.ITE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTASENTRADAS>().Property((ITENSNOTASENTRADAS e) => e.ITE_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTASENTRADAS>().Property((ITENSNOTASENTRADAS e) => e.ITE_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTASENTRADAS>().Property((ITENSNOTASENTRADAS e) => e.ITE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTASENTRADAS>().Property((ITENSNOTASENTRADAS e) => e.ITE_CST).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTAVENDAS>().Property((ITENSNOTAVENDAS e) => e.IVE_ITENSNOTA_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSNOTAVENDAS>().Property((ITENSNOTAVENDAS e) => e.IVE_VENDAS_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDO>().Property((ITENSPEDIDO e) => e.ITE_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDO>().Property((ITENSPEDIDO e) => e.ITE_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDO>().Property((ITENSPEDIDO e) => e.ITE_PEDIDO_VENDA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDOVENDA>().Property((ITENSPEDIDOVENDA e) => e.ITE_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDOVENDA>().Property((ITENSPEDIDOVENDA e) => e.ITE_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDOVENDA>().Property((ITENSPEDIDOVENDA e) => e.ITE_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDOVENDA>().Property((ITENSPEDIDOVENDA e) => e.ITE_PEDIDO_COMPRA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSPEDIDOVENDA>().Property((ITENSPEDIDOVENDA e) => e.ITE_MOTIVO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARACAO>().Property((ITENSSEPARACAO e) => e.ITS_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARACAO>().Property((ITENSSEPARACAO e) => e.ITS_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARACAO>().Property((ITENSSEPARACAO e) => e.ITS_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARAVENDA>().Property((ITENSSEPARAVENDA e) => e.ISV_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARAVENDA>().Property((ITENSSEPARAVENDA e) => e.ISV_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ITENSSEPARAVENDA>().Property((ITENSSEPARAVENDA e) => e.ISV_PRODUTO).IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_CCUSTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_HORA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LANCAMENTOCONTA>().Property((LANCAMENTOCONTA e) => e.LAN_STATUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LINHA>().Property((LINHA e) => e.LIN_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<LINHA>().Property((LINHA e) => e.LIN_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAIS>().Property((MATERIAIS e) => e.MAT_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAIS>().Property((MATERIAIS e) => e.MAT_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAIS_LOCALIZACAO>().Property((MATERIAIS_LOCALIZACAO e) => e.MAL_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAIS_LOCALIZACAO>().Property((MATERIAIS_LOCALIZACAO e) => e.MAL_ENDERECAMENTO).IsUnicode(false);
        modelBuilder.Entity<MATERIAISCONVERSAO>().Property((MATERIAISCONVERSAO e) => e.MAC_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISCONVERSAO>().Property((MATERIAISCONVERSAO e) => e.MAC_PRODUTO_DESTINO).IsUnicode(false);
        modelBuilder.Entity<MATERIAISCOR>().Property((MATERIAISCOR e) => e.MAC_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISCOR>().Property((MATERIAISCOR e) => e.MAC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISCORSEQ>().Property((MATERIAISCORSEQ e) => e.MAC_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISCORSEQ>().Property((MATERIAISCORSEQ e) => e.MAC_REFERENCIA_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISLOCALIZACAO>().Property((MATERIAISLOCALIZACAO e) => e.MAL_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISLOCALIZACAO>().Property((MATERIAISLOCALIZACAO e) => e.MAL_ENDERECAMENTO).IsUnicode(false);
        modelBuilder.Entity<MATERIALCOR>().Property((MATERIALCOR e) => e.MAT_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALCOR>().Property((MATERIALCOR e) => e.MAT_MATERIAL).IsUnicode(false);
        modelBuilder.Entity<MATERIALCOR>().Property((MATERIALCOR e) => e.MAT_COR).IsUnicode(false);
        modelBuilder.Entity<MATERIALCOR>().Property((MATERIALCOR e) => e.MAT_REFERENCIA).IsUnicode(false);
        modelBuilder.Entity<MATERIALCOR>().Property((MATERIALCOR e) => e.MAT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_SUBGRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_REFERENCIA_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_UNIDADE_E).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_UNIDADE_C).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_GRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_FASE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_SETOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_MOEDA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIALPRODUCAO>().Property((MATERIALPRODUCAO e) => e.MTP_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAPRIMA>().Property((MATERIAPRIMA e) => e.MAP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<META>().Property((META e) => e.MET_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<METAFORMA>().Property((METAFORMA e) => e.MET_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<METAPRODUTO>().Property((METAPRODUTO e) => e.MEP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<METAVALOR>().Property((METAVALOR e) => e.MET_SEQ).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MODELOS>().Property((MODELOS e) => e.MOD_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MODELOS>().Property((MODELOS e) => e.MOD_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOEDAS>().Property((MOEDAS e) => e.MOE_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOEDAS>().Property((MOEDAS e) => e.MOE_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOTIVOBAIXA>().Property((MOTIVOBAIXA e) => e.MOT_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOTIVOBAIXA>().Property((MOTIVOBAIXA e) => e.MOT_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOTIVOLOJA>().Property((MOTIVOLOJA e) => e.MOT_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOTIVOLOJA>().Property((MOTIVOLOJA e) => e.MOT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOVIMENTACAOESTOQUE>().Property((MOVIMENTACAOESTOQUE e) => e.MOE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MOVIMENTACAOESTOQUE>().Property((MOVIMENTACAOESTOQUE e) => e.MOE_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MUNICIPIO>().Property((MUNICIPIO e) => e.MUN_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NCM>().Property((NCM e) => e.NCM_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<NCM>().Property((NCM e) => e.NCM_NCM).IsUnicode(false);
        modelBuilder.Entity<NCM>().Property((NCM e) => e.NCM_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NFE_LOTE>().Property((NFE_LOTE e) => e.NFL_RECIBO).IsUnicode(false);
        modelBuilder.Entity<NFECARTACORRECAO>().Property((NFECARTACORRECAO e) => e.NFC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NFECARTACORRECAO>().Property((NFECARTACORRECAO e) => e.NFC_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<NFECARTACORRECAO>().Property((NFECARTACORRECAO e) => e.NFC_PROTOCOLO).IsUnicode(false);
        modelBuilder.Entity<NFEREFERENCIADA>().Property((NFEREFERENCIADA e) => e.NRE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NFEREFERENCIADA>().Property((NFEREFERENCIADA e) => e.NRE_CHAVE).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_STATUS_SERVICO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_ENVIO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_RETORNO_ENVIO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_CONSULTA).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_CANCELAMENTO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_INUTILIZACAO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_VERSAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_EVENTO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_AUTORIZACAO).IsUnicode(false);
        modelBuilder.Entity<NFEWS>().Property((NFEWS e) => e.NWS_RETORNO_AUTORIZACAO).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_MARCA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_ESPECIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_STATUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_VIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_TIPO_DESCONTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_ESTOQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_AGRUPAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_GERAR_DUPLICATA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_TIPO_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_NFE_CHAVE).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_NFE_PROTOCOLO).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_CAIXA_DOC).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_CHAVE).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_MD5).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<NOTA_FISCAL>().Property((NOTA_FISCAL e) => e.NOT_PLACA).IsUnicode(false);
        modelBuilder.Entity<NOTACREDITO>().Property((NOTACREDITO e) => e.NOC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTACREDITO>().Property((NOTACREDITO e) => e.NOC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAFISCALAUXILIAR>().Property((NOTAFISCALAUXILIAR e) => e.NFA_DOC_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAFISCALAUXILIAR>().Property((NOTAFISCALAUXILIAR e) => e.NFA_DOC_AUXILIAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAINUTILIZADA>().Property((NOTAINUTILIZADA e) => e.NOI_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAINUTILIZADA>().Property((NOTAINUTILIZADA e) => e.NOI_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAINUTILIZADA>().Property((NOTAINUTILIZADA e) => e.NOI_PROTOCOLO).IsUnicode(false);
        modelBuilder.Entity<NOTAREJEITADA>().Property((NOTAREJEITADA e) => e.NOR_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTAREJEITADA>().Property((NOTAREJEITADA e) => e.NOR_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<NOTAREJEITADA>().Property((NOTAREJEITADA e) => e.NOR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_SERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_MODELO).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADAS>().Property((NOTASENTRADAS e) => e.NOT_NFE_CHAVE).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_SERIE).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_SUBSERIE).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_NUMERO).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_MODELO).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASCONHECIMENTO>().Property((NOTASENTRADASCONHECIMENTO e) => e.NEC_CTE_CHAVE).IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASSERIE>().Property((NOTASENTRADASSERIE e) => e.NOS_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASSERIE>().Property((NOTASENTRADASSERIE e) => e.NOS_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASSERIE>().Property((NOTASENTRADASSERIE e) => e.NOS_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTASENTRADASSERIE>().Property((NOTASENTRADASSERIE e) => e.NOS_SERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTICIAS>().Property((NOTICIAS e) => e.NOT_TITULO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NOTICIAUSUARIO>().Property((NOTICIAUSUARIO e) => e.NOU_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Numero).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Centro_Custo).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Obs).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Nota_Fiscal).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Duplicata).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Moeda).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Fornecedor).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Cheque).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.Pag_Status).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.PAG_PARCELAS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.PAG_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.PAG_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PAGAMENTOS>().Property((PAGAMENTOS e) => e.PAG_BARRA).IsUnicode(false);
        modelBuilder.Entity<PAIS>().Property((PAIS e) => e.PAI_NOME).IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_CHEQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_DEVOLVIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_AGENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_CONTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_CUSTODIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_PARCELA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS>().Property((PARCELAS e) => e.PAR_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS_CARTAO>().Property((PARCELAS_CARTAO e) => e.PARC_PARCELAS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS_CARTAO>().Property((PARCELAS_CARTAO e) => e.PARC_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS_CARTAO>().Property((PARCELAS_CARTAO e) => e.PARC_RESUMO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS_CARTAO>().Property((PARCELAS_CARTAO e) => e.PARC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PARCELAS_CARTAO>().Property((PARCELAS_CARTAO e) => e.PARC_NSU).IsUnicode(false);
        modelBuilder.Entity<PARENTESCO>().Property((PARENTESCO e) => e.PAR_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOETIQUETA>().Property((PEDIDOETIQUETA e) => e.PED_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOETIQUETA>().Property((PEDIDOETIQUETA e) => e.PED_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOETIQUETA>().Property((PEDIDOETIQUETA e) => e.PED_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOS>().Property((PEDIDOS e) => e.PED_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOS>().Property((PEDIDOS e) => e.PED_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOS>().Property((PEDIDOS e) => e.PED_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOS>().Property((PEDIDOS e) => e.PED_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOSVENDA>().Property((PEDIDOSVENDA e) => e.PED_PEDIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOSVENDA>().Property((PEDIDOSVENDA e) => e.PED_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOSVENDA>().Property((PEDIDOSVENDA e) => e.PED_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOSVENDA>().Property((PEDIDOSVENDA e) => e.PED_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PEDIDOSVENDA>().Property((PEDIDOSVENDA e) => e.PED_PEDIDO_EXTERNO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PRECO>().Property((PRECO e) => e.PRE_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PRECO>().Property((PRECO e) => e.PRE_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PRODUTONEGATIVO>().Property((PRODUTONEGATIVO e) => e.PRN_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PRODUTONEGATIVO>().Property((PRODUTONEGATIVO e) => e.PRN_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PROFISSAO>().Property((PROFISSAO e) => e.PRO_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<PROMOCAOPECAS>().Property((PROMOCAOPECAS e) => e.PRP_PROMOCAO);
        modelBuilder.Entity<RECEBEARQUIVO>().Property((RECEBEARQUIVO e) => e.REC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBEARQUIVO>().Property((RECEBEARQUIVO e) => e.REC_DADOS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBEARQUIVO>().Property((RECEBEARQUIVO e) => e.REC_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_CENTRO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_STATUS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_PARCELAS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_CHEQUE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_MOEDA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_TIPO_DEVEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RECEBER>().Property((RECEBER e) => e.REC_DOCUMENTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIACATEGORIA>().Property((REFERENCIACATEGORIA e) => e.REC_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_REFERENCIA_FORNECEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_DESC2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS>().Property((REFERENCIAS e) => e.REF_CLASSIFICACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIAS_ADICIONAL>().Property((REFERENCIAS_ADICIONAL e) => e.RAD_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASCOMENTARIOS>().Property((REFERENCIASCOMENTARIOS e) => e.REC_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASCOMENTARIOS>().Property((REFERENCIASCOMENTARIOS e) => e.REC_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASCOMENTARIOS>().Property((REFERENCIASCOMENTARIOS e) => e.REC_COMENTARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASCOMENTARIOS>().Property((REFERENCIASCOMENTARIOS e) => e.REC_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASCOMENTARIOS>().Property((REFERENCIASCOMENTARIOS e) => e.REC_HORA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASITE>().Property((REFERENCIASITE e) => e.RES_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REFERENCIASITE>().Property((REFERENCIASITE e) => e.RES_NOME).IsUnicode(false);
        modelBuilder.Entity<REFERENCIASITE>().Property((REFERENCIASITE e) => e.RES_PALAVRAS).IsUnicode(false);
        modelBuilder.Entity<REGIAO>().Property((REGIAO e) => e.REG_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REGISTROBONUS>().Property((REGISTROBONUS e) => e.REG_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REGISTROBONUS>().Property((REGISTROBONUS e) => e.REG_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REGISTROPROMOCAO>().Property((REGISTROPROMOCAO e) => e.REG_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REGISTROPROMOCAO>().Property((REGISTROPROMOCAO e) => e.REG_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REGISTROPROMOCAO>().Property((REGISTROPROMOCAO e) => e.REG_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REGRAS>().Property((REGRAS e) => e.REG_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REGRAS>().Property((REGRAS e) => e.REG_MENSAGEM).IsUnicode(false);
        modelBuilder.Entity<REGRAS>().Property((REGRAS e) => e.REG_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<REMANEJA>().Property((REMANEJA e) => e.REM_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REMANEJA>().Property((REMANEJA e) => e.REM_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<REMANEJA>().Property((REMANEJA e) => e.REM_PRODUTO).IsUnicode(false);
        modelBuilder.Entity<REMESSA>().Property((REMESSA e) => e.REM_OBS).IsUnicode(false);
        modelBuilder.Entity<REMESSA>().Property((REMESSA e) => e.REM_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<REMESSA>().Property((REMESSA e) => e.REM_CONTA).IsUnicode(false);
        modelBuilder.Entity<REMESSA>().Property((REMESSA e) => e.REM_CARTEIRA).IsUnicode(false);
        modelBuilder.Entity<REMESSACARTEIRA>().Property((REMESSACARTEIRA e) => e.RCA_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REMESSACARTEIRA>().Property((REMESSACARTEIRA e) => e.RCA_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REMESSACONFIGURACAO>().Property((REMESSACONFIGURACAO e) => e.REC_BANCO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REMESSACONFIGURACAO>().Property((REMESSACONFIGURACAO e) => e.REC_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REMESSACONFIGURACAO>().Property((REMESSACONFIGURACAO e) => e.REC_INSTRUCAO1).IsUnicode(false);
        modelBuilder.Entity<REMESSACONFIGURACAO>().Property((REMESSACONFIGURACAO e) => e.REC_INSTRUCAO2).IsUnicode(false);
        modelBuilder.Entity<REMESSACONFIGURACAO>().Property((REMESSACONFIGURACAO e) => e.REC_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<REMESSAINSTRUCAO>().Property((REMESSAINSTRUCAO e) => e.REI_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REMESSAINSTRUCAO>().Property((REMESSAINSTRUCAO e) => e.REI_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_ENDERECO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_BAIRRO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_CIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_CEP).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_ESTADO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_CELULAR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_EMAIL2).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_CHAVE).IsUnicode(false);
        modelBuilder.Entity<REPRESENTANTE>().Property((REPRESENTANTE e) => e.REP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<REQUISICAOFILA>().Property((REQUISICAOFILA e) => e.REF_BODY).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RESUMOFORMA>().Property((RESUMOFORMA e) => e.RES_COO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RESUMOFORMA>().Property((RESUMOFORMA e) => e.RES_FORMA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RESUMOFORMA>().Property((RESUMOFORMA e) => e.RES_SERIAL).IsUnicode(false);
        modelBuilder.Entity<RETORNO_ERROS>().Property((RETORNO_ERROS e) => e.REE_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RETORNO_ERROS>().Property((RETORNO_ERROS e) => e.REE_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<RETORNO_OCORRENCIA>().Property((RETORNO_OCORRENCIA e) => e.RET_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<RETORNO_OCORRENCIA>().Property((RETORNO_OCORRENCIA e) => e.RET_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<ROTA>().Property((ROTA e) => e.ROT_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ROTA>().Property((ROTA e) => e.ROT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ROTAFASE>().Property((ROTAFASE e) => e.ROF_FASE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ROTAFASE>().Property((ROTAFASE e) => e.ROF_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ROTAFASE>().Property((ROTAFASE e) => e.ROT_FASE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<ROTAFASE>().Property((ROTAFASE e) => e.ROT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SALDOS>().Property((SALDOS e) => e.SAL_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SALDOSC>().Property((SALDOSC e) => e.SAL_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SEPARACAOPEDIDO>().Property((SEPARACAOPEDIDO e) => e.SEP_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SEPARACAOPEDIDO>().Property((SEPARACAOPEDIDO e) => e.SEP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SEPARAVENDA>().Property((SEPARAVENDA e) => e.SEV_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SEPARAVENDA>().Property((SEPARAVENDA e) => e.SEV_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SETOR>().Property((SETOR e) => e.SET_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SETOR>().Property((SETOR e) => e.SET_FASE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SETOR>().Property((SETOR e) => e.SET_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SETOR>().Property((SETOR e) => e.SET_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SITECATEGORIA>().Property((SITECATEGORIA e) => e.SCA_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<SITECATEGORIA>().Property((SITECATEGORIA e) => e.SCA_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<SITECATEGORIA>().Property((SITECATEGORIA e) => e.SCA_PALAVRAS).IsUnicode(false);
        modelBuilder.Entity<SITECATEGORIA>().Property((SITECATEGORIA e) => e.SCA_OBS).IsUnicode(false);
        modelBuilder.Entity<SUBGRUPO>().Property((SUBGRUPO e) => e.SUB_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SUBGRUPO>().Property((SUBGRUPO e) => e.SUB_GRUPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SUBGRUPO>().Property((SUBGRUPO e) => e.SUB_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SUBGRUPO>().Property((SUBGRUPO e) => e.SUB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TABELAPRECO>().Property((TABELAPRECO e) => e.TAB_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TABELAPRECO>().Property((TABELAPRECO e) => e.TAB_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TABELAPRECO>().Property((TABELAPRECO e) => e.TAB_DESCRICAO_FRANQUIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TABELATRIBUTO>().Property((TABELATRIBUTO e) => e.TAT_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TABELATRIBUTO>().Property((TABELATRIBUTO e) => e.TAT_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TAMANHOS>().Property((TAMANHOS e) => e.TAM_TAMANHO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TAMANHOS>().Property((TAMANHOS e) => e.TAM_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TAREFAS>().Property((TAREFAS e) => e.TAR_DESCRICAO).IsUnicode(false);
        modelBuilder.Entity<TEFNOVA>().Property((TEFNOVA e) => e.TEF_NSU).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TEFNOVA>().Property((TEFNOVA e) => e.TEF_FINALIZACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TEFNOVA>().Property((TEFNOVA e) => e.TEF_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPOCLIENTE>().Property((TIPOCLIENTE e) => e.TIP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPOCLIENTE>().Property((TIPOCLIENTE e) => e.TIP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPODESCONTO>().Property((TIPODESCONTO e) => e.TIP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPODESCONTO>().Property((TIPODESCONTO e) => e.TIP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPONOTA>().Property((TIPONOTA e) => e.TIP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPONOTA>().Property((TIPONOTA e) => e.TIP_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPOPRODUCAO>().Property((TIPOPRODUCAO e) => e.TIP_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TIPOPRODUCAO>().Property((TIPOPRODUCAO e) => e.TIP_SINTEGRA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSFERENCIAOBS>().Property((TRANSFERENCIAOBS e) => e.TRO_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSFERENCIAOBS>().Property((TRANSFERENCIAOBS e) => e.TRO_OBS).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_CGC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_INSCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_CONTATO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_FANTASIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_CHAVE).IsUnicode(false);
        modelBuilder.Entity<TRANSPORTADORAS>().Property((TRANSPORTADORAS e) => e.TRA_PLACA).IsUnicode(false);
        modelBuilder.Entity<UNIDADES>().Property((UNIDADES e) => e.UNI_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<UNIDADES>().Property((UNIDADES e) => e.UNI_PREFIXO).IsUnicode(false);
        modelBuilder.Entity<USUARIOCOLUNA>().Property((USUARIOCOLUNA e) => e.USC_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOFILIAL>().Property((USUARIOFILIAL e) => e.USF_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOFILIAL>().Property((USUARIOFILIAL e) => e.USF_MATRICULA).IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_SENHA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_ABREVIADO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_DEPTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_CHAVE_WEB).IsUnicode(false);
        modelBuilder.Entity<USUARIOS>().Property((USUARIOS e) => e.US_EMAIL).IsUnicode(false);
        modelBuilder.Entity<USUARIOTELADESENHO>().Property((USUARIOTELADESENHO e) => e.USD_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOTELADESENHO>().Property((USUARIOTELADESENHO e) => e.USD_USUARIO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<USUARIOTELADESENHO>().Property((USUARIOTELADESENHO e) => e.USD_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_NUMERO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_DOC_SAIDA).IsUnicode(false);
        modelBuilder.Entity<VALES>().Property((VALES e) => e.VAL_DOC_ENTRADA).IsUnicode(false);
        modelBuilder.Entity<VENDAS>().Property((VENDAS e) => e.VEN_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDAS>().Property((VENDAS e) => e.VEN_SITUACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDAS>().Property((VENDAS e) => e.VEN_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDASENTREGA>().Property((VENDASENTREGA e) => e.VEE_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDASENTREGA>().Property((VENDASENTREGA e) => e.VEE_ENDERECO).IsUnicode(false);
        modelBuilder.Entity<VENDASENTREGA>().Property((VENDASENTREGA e) => e.VEE_CHAVE).IsUnicode(false);
        modelBuilder.Entity<VENDASSERIE>().Property((VENDASSERIE e) => e.VES_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDASSERIE>().Property((VENDASSERIE e) => e.VES_SERIE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDASSERIE>().Property((VENDASSERIE e) => e.VES_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_APELIDO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_PREFIXO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_FAX).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_TELEFONE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_TIPO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_CPF).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_IDENTIDADE).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_OBSERVACAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_PROFISSAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_CREA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_EMAIL).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_CHAVE).IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_AGENCIA).IsUnicode(false);
        modelBuilder.Entity<VENDEDORES>().Property((VENDEDORES e) => e.VEN_CONTA).IsUnicode(false);
        modelBuilder.Entity<VERSOES>().Property((VERSOES e) => e.VER_DESCRICAO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<APROVEITAMENTO>().Property((APROVEITAMENTO e) => e.APR_VENDEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<APROVEITAMENTO>().Property((APROVEITAMENTO e) => e.APR_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DEPENDENTE>().Property((DEPENDENTE e) => e.DEP_CODIGON).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DEPENDENTE>().Property((DEPENDENTE e) => e.DEP_NOME).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DEVOLUCAOATACADO>().Property((DEVOLUCAOATACADO e) => e.DEV_CODIGO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<DEVOLUCAOATACADO>().Property((DEVOLUCAOATACADO e) => e.DEV_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAISPROMOCAO>().Property((MATERIAISPROMOCAO e) => e.PRO_PRODUTO).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<METAVENDEDOR>().Property((METAVENDEDOR e) => e.MET_VENDEDOR).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<NUMERO_NOTA>().Property((NUMERO_NOTA e) => e.PRI_NOTA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRIBUTO>().Property((TRIBUTO e) => e.TRI_REFERENCIA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<TRIBUTO>().Property((TRIBUTO e) => e.TRI_MATRICULA).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<SINCRONISMONEGOCIO>().Property((SINCRONISMONEGOCIO e) => e.SIN_DOC).IsFixedLength()
            .IsUnicode(false);
        modelBuilder.Entity<MATERIAIS>().HasRequired((MATERIAIS x) => x.REFERENCIAS).WithMany((REFERENCIAS x) => x.MATERIAIS)
            .HasForeignKey((MATERIAIS x) => new { x.MAT_REFERENCIA, x.MAT_REDE });
        modelBuilder.Entity<MATERIAIS>().HasRequired((MATERIAIS x) => x.CORES).WithMany((CORES x) => x.MATERIAIS)
            .HasForeignKey((MATERIAIS x) => new { x.MAT_COR });
        modelBuilder.Entity<MATERIAIS>().HasRequired((MATERIAIS x) => x.TAMANHOS).WithMany((TAMANHOS x) => x.MATERIAIS)
            .HasForeignKey((MATERIAIS x) => new { x.MAT_TAMANHO });
        modelBuilder.Entity<MATERIAIS>().HasMany((MATERIAIS x) => x.PRECO).WithRequired((PRECO x) => x.MATERIAIS)
            .HasForeignKey((PRECO x) => new { x.PRE_PRODUTO });
        modelBuilder.Entity<MATERIAIS>().HasMany((MATERIAIS x) => x.SALDOS).WithRequired((SALDOS x) => x.MATERIAIS)
            .HasForeignKey((SALDOS x) => new { x.SAL_PRODUTO });
        modelBuilder.Entity<MATERIAIS>().HasMany((MATERIAIS x) => x.MATERIAISPROMOCAO).WithRequired((MATERIAISPROMOCAO x) => x.MATERIAIS)
            .HasForeignKey((MATERIAISPROMOCAO x) => new { x.PRO_PRODUTO });
        modelBuilder.Entity<REGISTROPROMOCAO>().HasMany((REGISTROPROMOCAO x) => x.MATERIAISPROMOCAO).WithRequired((MATERIAISPROMOCAO x) => x.REGISTROPROMOCAO)
            .HasForeignKey((MATERIAISPROMOCAO x) => new { x.PRO_CODIGO });
        modelBuilder.Entity<REFERENCIAS>().HasRequired((REFERENCIAS x) => x.COLECOES).WithMany((COLECOES x) => x.REFERENCIAS)
            .HasForeignKey((REFERENCIAS x) => new { x.REF_COLECAO });
        modelBuilder.Entity<REFERENCIAS>().HasMany((REFERENCIAS x) => x.TRIBUTO).WithRequired((TRIBUTO x) => x.REFERENCIAS)
            .HasForeignKey((TRIBUTO x) => new { x.TRI_REFERENCIA, x.TRI_REDE });
        modelBuilder.Entity<REFERENCIAS>().HasRequired((REFERENCIAS x) => x.LINHA).WithMany((LINHA x) => x.REFERENCIAS)
            .HasForeignKey((REFERENCIAS x) => new { x.REF_LINHA });
        modelBuilder.Entity<REFERENCIAS>().HasRequired((REFERENCIAS x) => x.MODELOS).WithMany((MODELOS x) => x.REFERENCIAS)
            .HasForeignKey((REFERENCIAS x) => new { x.REF_MODELO });
        modelBuilder.Entity<REFERENCIAS>().HasRequired((REFERENCIAS x) => x.UNIDADES).WithMany((UNIDADES x) => x.REFERENCIAS)
            .HasForeignKey((REFERENCIAS x) => new { x.REF_UNIDADE2 });
        modelBuilder.Entity<CLIENTES>().HasRequired((CLIENTES s) => s.ENDERECO).WithMany((ENDERECO x) => x.CLIENTES)
            .HasForeignKey((CLIENTES x) => new { x.CLI_TIPO_CADASTRO, x.CLI_CODIGON, x.CLI_ENDERECO_PADRAO });
        modelBuilder.Entity<FILIAL>().HasRequired((FILIAL s) => s.ENDERECO).WithMany((ENDERECO x) => x.FILIAL)
            .HasForeignKey((FILIAL x) => new { x.FIL_TIPO_CADASTRO, x.FIL_CHAVE, x.FIL_ENDERECO_PADRAO });
        modelBuilder.Entity<CAIXA>().HasOptional((CAIXA s) => s.CLIENTES).WithMany((CLIENTES x) => x.CAIXA)
            .HasForeignKey((CAIXA x) => new { x.CAI_CODIGON });
        modelBuilder.Entity<FILIAL>().HasMany((FILIAL s) => s.CAIXA).WithRequired((CAIXA x) => x.FILIAL)
            .HasForeignKey((CAIXA x) => new { x.CAI_FILIAL });
        modelBuilder.Entity<FILIAL>().HasMany((FILIAL s) => s.SALDOS).WithRequired((SALDOS x) => x.FILIAL)
            .HasForeignKey((SALDOS x) => new { x.SAL_FILIAL });
        modelBuilder.Entity<CLIENTES>().HasRequired((CLIENTES x) => x.FILIAL).WithMany((FILIAL x) => x.CLIENTES)
            .HasForeignKey((CLIENTES x) => new { x.CLI_FILIAL });
        modelBuilder.Entity<ESTADO>().HasKey((ESTADO x) => x.EST_COD_IBGE);
        modelBuilder.Entity<PIXTRANSACAO>().Property((PIXTRANSACAO x) => x.PIT_ID).HasColumnOrder(1);
        modelBuilder.Entity<PIXTRANSACAO>().Property((PIXTRANSACAO x) => x.PIT_SEQ).HasColumnOrder(2);
        modelBuilder.Entity<CAIXAPIX>().Property((CAIXAPIX x) => x.CAP_DOC).HasColumnOrder(1);
        modelBuilder.Entity<CAIXAPIX>().Property((CAIXAPIX x) => x.CAP_SEQ).HasColumnOrder(2);
        modelBuilder.Entity<VEICULO>().HasRequired((VEICULO x) => x.ESTADO).WithMany((ESTADO x) => x.VEICULO)
            .HasForeignKey((VEICULO x) => new { x.VEI_UF });
    }
    /*
	public static Expression CriarCondicaoLambdaTelaProcura(List<Type> tabelasJoin, TelaProcuraParametros telaProcuraParametros)
	{
		foreach (Type item in tabelasJoin)
		{
			PropertyInfo[] properties = item.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.Name.ToLower() == telaProcuraParametros.TelaProcuraDados.Campo.ToLower())
				{
					return CriarCondicaoLambdaTelaProcura(item, telaProcuraParametros);
				}
			}
		}
		return null;
	}

	public static Expression CriarCondicaoLambdaTelaProcura(Type tipo, TelaProcuraParametros parametros, string SubPropriedade = "")
	{
		try
		{
			Type type = null;
			switch (parametros.TelaProcuraDados.TipoProcura)
			{
			case enumTipoProcura.Data:
				type = typeof(DateTime);
				break;
			case enumTipoProcura.Texto:
			case enumTipoProcura.TextoLike:
				type = typeof(string);
				break;
			case enumTipoProcura.Numero:
			case enumTipoProcura.Valor:
				type = typeof(double);
				break;
			default:
				throw new Exception("Tipo de tela procura não implementada para criar condição lambda." + Environment.NewLine + parametros.TelaProcuraDados.TipoProcura);
			}
			ParameterExpression parameterExpression = Expression.Parameter(tipo);
			Expression expression = parameterExpression;
			if (SubPropriedade.ReceberString() != "")
			{
				string[] array = (SubPropriedade + "." + parametros.TelaProcuraDados.Campo).Split('.');
				foreach (string propertyOrFieldName in array)
				{
					expression = Expression.PropertyOrField(expression, propertyOrFieldName);
				}
			}
			else
			{
				expression = Expression.Property(parameterExpression, parametros.TelaProcuraDados.Campo);
			}
			ConstantExpression right = Expression.Constant(parametros.Valor1);
			BinaryExpression binaryExpression = null;
			if (parametros.Valor2 == null)
			{
				binaryExpression = ((parametros.TelaProcuraDados.TipoProcura != enumTipoProcura.Numero) ? Expression.Equal(Expression.Convert(expression, type), right) : Expression.Equal(Expression.Convert(expression, type), right));
			}
			else
			{
				binaryExpression = Expression.GreaterThanOrEqual(Expression.Convert(expression, type), right);
				ConstantExpression right2 = Expression.Constant(parametros.Valor2);
				BinaryExpression right3 = Expression.LessThanOrEqual(Expression.Convert(expression, type), right2);
				binaryExpression = Expression.AndAlso(binaryExpression, right3);
			}
			return Expression.Lambda(binaryExpression, parameterExpression);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public static string CriarCondicaoStringTelaProcura(TelaProcuraParametros parametros)
	{
		try
		{
			string text = "";
			if (parametros == null)
			{
				return "";
			}
			Comando comando = new Comando(new Conexao(""));
			StringBuilder stringBuilder = new StringBuilder();
			string text2 = "";
			stringBuilder.Append(" AND " + parametros.TelaProcuraDados.Campo);
			if (parametros.TelaProcuraDados.Formatar)
			{
				text2 = ((parametros.TelaProcuraDados.Campo.IndexOf("CGC") <= -1) ? parametros.Valor1.ReceberString().PadLeft(parametros.TelaProcuraDados.Tamanho, '0') : Formatacao.TratarCNPJCPF(parametros.Valor1.ReceberString()));
			}
			switch (parametros.TelaProcuraDados.TipoProcura)
			{
			case enumTipoProcura.Data:
				stringBuilder.Append(" BETWEEN @DATA1 AND @DATA2 ");
				comando.Query = stringBuilder.ToString();
				comando.AdicionarParametro("@DATA1", parametros.Valor1.ReceberDateTime());
				comando.AdicionarParametro("@DATA2", parametros.Valor2.ReceberDateTime(horaFinal: true));
				break;
			case enumTipoProcura.Texto:
				if (text2.Length == 0)
				{
					text2 = parametros.Valor1.ReceberString().Trim();
				}
				if (parametros.TelaProcuraDados.Parcial)
				{
					stringBuilder.Clear();
					stringBuilder.Append(" AND SUBSTRING(" + parametros.TelaProcuraDados.Campo + ",1, " + text2.Length + ") = @TEXTO");
				}
				else
				{
					stringBuilder.Append(" = @TEXTO ");
				}
				comando.Query = stringBuilder.ToString();
				comando.AdicionarParametro("@TEXTO", text2);
				break;
			case enumTipoProcura.TextoLike:
				if (text2.Length == 0)
				{
					text2 = parametros.Valor1.ReceberString().Trim();
				}
				if (text2.IndexOf(" ") > -1)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					string[] array = text2.Split(' ');
					foreach (string text3 in array)
					{
						stringBuilder2.Append("%" + text3 + "%");
					}
					text2 = stringBuilder2.ToString();
				}
				else
				{
					text2 = "%" + text2 + "%";
				}
				stringBuilder.Append(" LIKE @TEXTO");
				comando.Query = stringBuilder.ToString();
				comando.AdicionarParametro("@TEXTO", text2);
				break;
			case enumTipoProcura.Numero:
				stringBuilder.Append(" = @NUMERO ");
				comando.Query = stringBuilder.ToString();
				comando.AdicionarParametro("@NUMERO", parametros.Valor1.ReceberInt32());
				break;
			case enumTipoProcura.Valor:
				stringBuilder.Append(" BETWEEN @VALOR1 AND @VALOR2 ");
				comando.Query = stringBuilder.ToString();
				comando.AdicionarParametro("@VALOR1", parametros.Valor1.ReceberDouble());
				comando.AdicionarParametro("@VALOR2", parametros.Valor1.ReceberDouble());
				break;
			}
			comando.AdicionarParametro("@VALOR2", parametros.Valor2.ReceberString());
			return comando.VisualizarQuery();
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	*/

}
