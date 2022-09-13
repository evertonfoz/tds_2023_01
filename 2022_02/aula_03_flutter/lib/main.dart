import 'dart:io';

import 'package:aula_03_flutter/app/utfpr_app.dart';
import 'package:aula_03_flutter/network/utfpr_http_overrides.dart';
import 'package:flutter/material.dart';

void main() {
  HttpOverrides.global = UtfprHttpOverrides();

  runApp(const UTFPRApp());
}
