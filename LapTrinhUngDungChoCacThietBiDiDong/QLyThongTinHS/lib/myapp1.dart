import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bmi_calculator/navbar.dart';

import 'classlopchitiet.dart';
import 'classpage.dart';
import 'models/classlop.dart';

class MyApp1 extends StatelessWidget{
  ClassLop classLop;
  @override
  Widget build (BuildContext context){
    return MaterialApp(
      title: 'Quản lý thông tin lý lịch',
      initialRoute: '/',
      routes: {
        '/HSPage': (context) => HSPage(classLop: this.classLop,),
        '/ClasPage': (context) => ClassPage()
      },
      home: Scaffold(
        drawer: Navbar(),
        appBar: AppBar(
          title: const Text('Thông tin lý lịch'),
        ),
        body: SafeArea(
          child: ClassPage(),
        ),
      ),
    );
  }
}