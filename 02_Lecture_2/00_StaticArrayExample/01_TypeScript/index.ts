class StaticArray {

    /*
        The constructor will represent the build step for the
        static array. This is an O(n) time complexity operation.
    */
    constructor(length: number) {
        if (length < 0) throw new Error('length out of range')

        this.count = length
        this.data = new Array(length)
    }

    count: number
    data: number[]

    // Return the length with an O(1) time complexity.
    length(): number {
        return this.count
    }

    // Get the value at the given index with an O(1) time complexity.
    getAt(index: number): number {
        if (index < 0 || index >= this.count) throw new Error('index out of range')
        return this.data[index]
    }

    // Set the value at the given index with an O(1) time complexity.
    setAt(index: number, value: number): void {
        if (index < 0 || index >= this.count) throw new Error('index out of range')
        this.data[index] = value 
    }

    // Insert the value at the given index with O(n) time complexity.
    insertAt(index: number, value: number): void {

        // A container is created with O(n) time complexity.
        const newArray: number[] = new Array(this.count + 1)

        // The values are copied from the previous container to the new
        // container with an O(n) time complexity.
        for (let i = 0; i < this.count; i++) {
            newArray[i] = this.data[i]
        }

        // The values are shifted in the new array with an O(n) time complexity.
        for (let j = this.count + 1; j >= index; j--) {
            newArray[j] = newArray[j - 1]
        }

        // The new value is assigned at the given index with an O(1) time complexity.
        newArray[index] = value

        this.data = newArray
        this.count += 1
    }

    // Delete the value at the given index with O(n) time complexity.
    deleteAt(index: number): void {

        // The values in the existing array are unshifted with an O(n) time complexity.
        for (let i = index; i < this.count - 1; i++) {
            this.data[i] = this.data[i + 1]
        }

        // A container is created with an O(n) time complexity.
        const newArray: number[] = new Array(this.count - 1)

        // The values are copied from the previous container to the new
        // container with an O(n) time complexity.
        for (let j = 0; j < this.count - 1; j++) {
            newArray[j] = this.data[j]
        }

        this.data = newArray
        this.count -= 1
    }

    // insertFirst is an O(n) time complexity operation.
    insertFirst(value: number): void {
        this.insertAt(0, value)
    }

    // deleteFirst is an O(n) time complexity operation.
    deleteFirst(): void {
        this.deleteAt(0)
    }

    // insertLast is an O(n) time complexity operation.
    insertLast(value: number): void {
        this.insertAt(this.count, value)
    }

    // deleteLast is an O(n) time complexity operation.
    deleteLast(): void {
        this.deleteAt(this.count - 1)
    }

    // iterSequence is an O(n) time complexity operation.
    iterSequence(): void {
        for (let i = 0; i < this.count; i++) {
            console.log(`index: ${i}\tvalue: ${this.data[i]}`)
        }
    }

}

const array: StaticArray = new StaticArray(3)

console.log(`a container has been created with length: ${array.count}`)

array.setAt(0, 1)
array.setAt(1, 2)
array.setAt(2, 3)

console.log('\nsetAt operations have been performed with the following result:')

array.iterSequence()

array.deleteFirst()

console.log('\ndeleteFirst operation has been performed with the following result:')

array.iterSequence()

array.insertFirst(1)

console.log('\ninsertFirst operation has been performed with the following result:')

array.iterSequence()

array.insertLast(4)

console.log('\ninsertLast operation has been performed with the following result:')

array.iterSequence()

array.deleteLast()

console.log('\ndeleteLast operation has been performed with the following result:')

array.iterSequence()

array.insertAt(1, 5)

console.log('\ninsertAt operation has been performed with the following result:')

array.iterSequence()

array.deleteAt(1)

console.log('\ndeleteAt operation has been performed with the following result:')

array.iterSequence()