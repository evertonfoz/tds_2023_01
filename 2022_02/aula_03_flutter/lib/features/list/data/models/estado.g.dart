// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'estado.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

EstadoModel _$EstadoModelFromJson(Map<String, dynamic> json) => EstadoModel(
      estadoID: json['estadoID'] as int?,
      uf: json['uf'] as String,
      nome: json['nome'] as String,
      urlBandeira: json['urlBandeira'] as String?,
    );

Map<String, dynamic> _$EstadoModelToJson(EstadoModel instance) =>
    <String, dynamic>{
      'estadoID': instance.estadoID,
      'uf': instance.uf,
      'nome': instance.nome,
      'urlBandeira': instance.urlBandeira,
    };
