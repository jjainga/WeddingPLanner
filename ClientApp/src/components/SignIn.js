import React, {useSate} from "react";



const SignIn = () => {



return (
    <div>
        <form>
            <div classname="form-group">
                <label for="exampleInputEmail1">Email address</label>
                <input type="email" classname="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
                    <small id="emailHelp" classname="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div classname="form-group">
                <label for="exampleInputPassword1">Password</label>
                <input type="password" classname="form-control" id="exampleInputPassword1" placeholder="Password" />
            </div>
            <div classname="form-group form-check">
                <input type="checkbox" classname="form-check-input" id="exampleCheck1" />
                <label classname="form-check-label" for="exampleCheck1">Check me out</label>
            </div>
                <button type="submit" classname="btn btn-primary">Submit</button>
        </form>
     

    </div>
    )
}

export default SignIn;
