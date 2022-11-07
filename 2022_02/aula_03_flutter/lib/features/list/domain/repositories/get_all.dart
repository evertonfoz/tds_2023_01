import 'dart:async';

import 'package:aula_03_flutter/core/failures.dart';
import 'package:aula_03_flutter/features/list/data/models/estado.dart';
import 'package:dartz/dartz.dart';

abstract class EstadoGetAllRepositoryContract {
  FutureOr<Either<Failure, List<EstadoModel>>> getAll();
}
