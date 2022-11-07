import 'package:equatable/equatable.dart';

class EstadoEntity extends Equatable {
  final int? estadoID;
  final String uf;
  final String nome;
  final String? urlBandeira;

  const EstadoEntity({
    this.estadoID,
    required this.uf,
    required this.nome,
    this.urlBandeira,
  });

  @override
  List<Object?> get props => [estadoID];
}
