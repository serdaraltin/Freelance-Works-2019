output "security_group_id" {
  value = "${aws_security_group.mydb1.id}"
}

output "rds_endpoint" {
  value = "${element(split(":", aws_db_instance.adventureworks.endpoint), 0)}"
}

output "rds_port" {
  value = "${aws_db_instance.adventureworks.port}"
}

output "rds_database" {
  value = "${aws_db_instance.adventureworks.name}"
}

output "rds_username" {
  value = "${aws_db_instance.adventureworks.username}"
}


output "private_subnet_1" {
  description = "List of IDs of private subnets"
  value = "${module.adventureworks_vpc.private_subnets[0]}"
}

output "public_subnet_1" {
  description = "List of IDs of public subnets"
  value       = "${module.adventureworks_vpc.public_subnets[0]}"
}

output "public_subnet_2" {
  description = "List of IDs of public subnets"
  value       = "${module.adventureworks_vpc.public_subnets[1]}"
}

output "region" {
  value = "${var.aws_region}"
}
