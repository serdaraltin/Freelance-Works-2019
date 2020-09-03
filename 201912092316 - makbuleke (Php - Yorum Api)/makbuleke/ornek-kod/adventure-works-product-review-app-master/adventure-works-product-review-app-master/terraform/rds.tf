resource "aws_db_instance" "adventureworks" {
  allocated_storage        = 10 # gigabytes
  db_subnet_group_name     = "${aws_db_subnet_group.default.name}"
  engine                   = "mysql"
  engine_version           = "5.7"
  identifier               = "adventureworks"
  instance_class           = "db.t2.micro"
  multi_az                 = false
  name                     = "adventureworks"
  parameter_group_name     = "default.mysql5.7"
  password                 = "foobarbaz"
  port                     = 3306
  publicly_accessible      = true
  storage_type             = "gp2"
  username                 = "foo"
  vpc_security_group_ids   = ["${aws_security_group.mydb1.id}"]
}

resource "aws_db_subnet_group" "default" {
  name       = "public_subnet_group"
  subnet_ids = ["${module.adventureworks_vpc.public_subnets[0]}","${module.adventureworks_vpc.public_subnets[1]}"]

  tags = {
    Name = "My DB subnet group"
  }
}