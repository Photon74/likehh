import './loginForm.css'
import React, { useState } from 'react'
import { Button } from '@mui/material'

const INIT_FORM = {
  email: '',
  password: '',
}

function LoginForm() {
  const [form, setForm] = useState(INIT_FORM)

  const changeForm = e => {
    e.persist()
    setForm(prev => {
      return {
        ...prev,
        [e.target.name]: e.target.value,
      }
    })
  }

  const onLogin = form => {

  }

  return (
    <div className='login'>
      <form>
        <div><label>Email</label></div>
        <div><input
          type="email"
          name='email'
          value={form.email}
          onChange={changeForm}
        /></div>
        <div><label>Password</label></div>
        <div><input
          type="text"
          name='password'
          value={form.password}
          onChange={changeForm}
        /></div>
        <Button
          type="submit"
          onClick={onLogin(form)}
        >
          Login
        </Button>
      </form>
    </div>
  )
}

export default LoginForm