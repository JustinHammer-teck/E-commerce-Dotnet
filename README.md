# E-commerce-DotNet-Angular


## Architecture

## Generic Repository

CONTENT

- Creating generic repository
- Specification Pattern
- Shaping Data 
- AutoMapper 
- Serve static content from API 

### Specification Pattern 



Use cases:

`Looking up data in the database. 
That is finding records that match the specification we have in hand.
Validating objects in the memory. 
In other words, checking that an object we retrieved or created fits the spec.
Creating a new instance that matches the criteria. This is useful in scenarios where you don’t care about the actual content of the instances, but still need it to have certain attributes.`






## Error Handling

- Error handling & exceptions
- Validation and improvement
- Swagger API document

### Error Handling

 - 200 range : OK
 - 300 range : Redirection
 - 400 range : Client Error
 - 500 range : Server Error

For deeper understanding on this topic : `https://developer.mozilla.org/en-US/docs/Web/HTTP/Status`

Custom Error & Validation Error Response with Exceptions Response Middleware 

Custom options for swagger in order to get the correct custom response  

## Paging, Sorting , Filtering , Searching

### Pagination 

Pros:
- Performance
- Params passed by query string 
- Limited page size 
- Paging the result only

### Deferred Execution
- Query commands are stored in a variable
- Execution of the query is deferred
- IQueryable<T> creates an expression tree
- Execution: 
    - ToList, ToArray, ToDictionary
    - Count or other sigleton queries    

- Adding CORS support

# Note

- SQLite does not support decimal




