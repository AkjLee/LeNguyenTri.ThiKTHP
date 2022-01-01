import 'package:flutter/material.dart';
import 'package:flutter_bmi_calculator/login_screen.dart';
import 'classlopchitiet.dart';
import 'classpage.dart';
import 'package:flutter_bmi_calculator/models/classlop.dart';

void main() {
  runApp(MyApp());
}
class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Quản Lý Thông Tin Lý Lịch',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: LoginScreen(),
    );
  }
}