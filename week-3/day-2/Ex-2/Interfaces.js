function introduce(person) {
    console.log("".concat(person.firstName, " ").concat(person.lastName, " is ").concat(person.age, " years old"));
}
var person = {
    firstName: 'Sahil',
    lastName: 'Gyanchandani',
    age: 21,
};
introduce(person);
