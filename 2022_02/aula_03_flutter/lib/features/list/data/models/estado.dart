import 'package:aula_03_flutter/features/list/domain/entities/estado.dart';
import 'package:json_annotation/json_annotation.dart';

/// flutter packages pub run build_runner watch --delete-conflicting-outputs

part 'estado.g.dart';

@JsonSerializable()
class EstadoModel extends EstadoEntity {
  const EstadoModel({
    super.estadoID,
    required super.uf,
    required super.nome,
    super.urlBandeira,
  });

  factory EstadoModel.fromJson(Map<String, dynamic> json) =>
      _$EstadoModelFromJson(json);

  /// Connect the generated [_$PersonToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$EstadoModelToJson(this);
}
