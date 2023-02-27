import React from 'react'
import LoginForm from '../Components/LoginForm/LoginForm'
import Menu from '../Components/Menu/Menu'

function LogInPage() {
  return (
    <>

      <div className="content">
        <h1>Log-In Page</h1>
        <LoginForm />
      </div>
      <Menu />
    </>

  )
}

export default LogInPage