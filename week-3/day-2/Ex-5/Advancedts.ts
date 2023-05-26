function getLength(value: string | any[]): number {
  return value.length;
}

const stringLength = getLength('Hello,Sahil');
console.log(stringLength); 

const arrayLength = getLength([1, 2, 3, 4, 5,'sahil',true]);
console.log(arrayLength);