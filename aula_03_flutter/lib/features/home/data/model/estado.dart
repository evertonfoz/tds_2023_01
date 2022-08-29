class EstadoModel {
  final int? estadoID;
  final String uf;
  final String nome;

  EstadoModel({
    this.estadoID,
    required this.uf,
    required this.nome,
  });

  factory EstadoModel.fromJson(Map<String, dynamic> json) {
    return EstadoModel(
      estadoID: json['estadoID'],
      uf: json['uf'],
      nome: json['nome'],
    );
  }
}
