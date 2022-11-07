import 'dart:async';

import 'package:aula_03_flutter/core/failures.dart';
import 'package:aula_03_flutter/core/use_case.dart';
import 'package:aula_03_flutter/features/list/data/models/estado.dart';
import 'package:aula_03_flutter/features/list/domain/entities/estado.dart';
import 'package:aula_03_flutter/features/list/domain/repositories/get_all.dart';
import 'package:dartz/dartz.dart';

class EstadoGetAllUseCase implements UseCase<List<EstadoEntity>, NoParams> {
  final EstadoGetAllRepositoryContract repository;

  EstadoGetAllUseCase({required this.repository});

  @override
  FutureOr<Either<Failure, List<EstadoModel>>> call(NoParams noParams) async {
    return await repository.getAll();
  }
}
