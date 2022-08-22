import 'package:aula_02_flutter/homepage.dart';
import 'package:aula_02_flutter/login.dart';
import 'package:flutter/material.dart';

class UTFPRApp extends StatelessWidget {
  const UTFPRApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Aula 01',
      // theme: ThemeData(
      //   // useMaterial3: true,
      //   primarySwatch: Colors.red,
      // ),
      home: LoginPage(),
    );
  }
}
