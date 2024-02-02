<template>
  <div>
    <form @submit.prevent="create" action="/assets/inc/sendemail.php">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="FullNameArm">Full Name in Armenian</label>
            <input v-model="createData.FullNameArm" type="text" id="FullNameArm" placeholder="Full name in Armenian" name="FullNameArm">
          </div>

          <div class="col">
            <label for="FullNameEng">Full name in English</label>
            <input v-model="createData.FullNameEng" type="text" id="FullNameEng" placeholder="Full name in English" name="FullNameEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="ProfessionArm">Profession in Armenian</label>
            <input v-model="createData.ProfessionArm" type="text" id="ProfessionArm" placeholder="Profession in Armenian" name="ProfessionArm">
          </div>

          <div class="col">
            <label for="ProfessionEng">Profession in English</label>
            <input v-model="createData.ProfessionEng" type="text" id="ProfessionEng" placeholder="Profession in English" name="ProfessionEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.DescriptionArm" id="descriptionArm" placeholder="Description in Armenian" name="descriptionArm"></textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.DescriptionEng" id="descriptionEng" placeholder="Description in English" name="descriptionEng"></textarea>
          </div>
        </div>

        <div class="row">
          <div class="col-12">
            <label for="Email">Email</label>
            <input v-model="createData.Email" type="email" id="Email" name="Email">
          </div>
        </div>

        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form><!-- /.become-teacher__form-content -->
  </div>
</template>

<script>
  import https from 'https';
  export default {
    name: 'CreateTeacher',
    setup() {
      return {
        createData: { FullNameArm: '', FullNameEng: '', Email: '', DescriptionEng: '', DescriptionArm: '', ProfessionArm: '', ProfessionEng: '' },
      };
    },
    methods: {
      async create() {
        try {
          await this.$axios.post('/api/Teachers/Create', this.createData)
          // Show success message
            .then(function (response) {
              if (response) {
                window.location = "/admin/teacher/list"
              }
            })
            .catch(function (error) {

            })
        } catch (error) {
          // Handle error and display message
        }
      },
    },
    created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  }
</script>

<style scoped>
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
