import 'package:aula_03_flutter/features/home/presentation/home.dart';
import 'package:flutter/material.dart';

class UTFPRApp extends StatelessWidget {
  const UTFPRApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'UTFPR Rest Client',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const HomePage(),
    );
  }
}
